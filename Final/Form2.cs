using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class Form2 : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\final.accdb")); //Checks for final.accdb on every system.
        OleDbCommand cmd = new OleDbCommand();

        public Form2(string value) // passes the username to the form
        {
            InitializeComponent();
            this.Text = "Main Form - " + value; // Shows the username for the second form.
        }

        void refillGrid()
        {
            cmd.CommandText = "select * from meds";
            OleDbDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            gridView.DataSource = dt;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MaximizeBox = false; // Prevents fullscreen button from working.
            conn.Open(); // opens a connection to the access file.
            cmd.Connection = conn; // Tells the cmd command to work in this connection.
            refillGrid();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close(); //Closes every relating form.
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gridView.SelectedRows) //For each row selected...
            {
                gridView.Rows.RemoveAt(this.gridView.SelectedRows[0].Index); //...it deletes the selected row (repeats for however many rows are selected).
            }
            updateBtn_Click(sender, e); //Then it updates the grid using update button's event.
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter dataAdapter =
                   new OleDbDataAdapter("select * from meds", conn);

            DataTable updatedDataTable = (DataTable)gridView.DataSource;

            OleDbCommandBuilder commandBuilder =
                new OleDbCommandBuilder(dataAdapter);

            dataAdapter.Update(updatedDataTable);
            refillGrid();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string ln = LNameBox.Text;
            string fn = FNameBox.Text;
            string num = phoneBox.Text;
            string res = IPBox.Text;
            string per = descBox.Text;

            cmd.CommandText = "insert into meds ([LName], [FName], [PhoneNum], [Residence], [Prescription]) values (@first,@second,@third,@fourth,@fifth)";

            //Tells the computer where to insert (column), the second half tells it what it should insert...

            cmd.Parameters.Add("@first", OleDbType.VarChar).Value = ln;
            cmd.Parameters.Add("@second", OleDbType.VarChar).Value = fn;
            cmd.Parameters.Add("@third", OleDbType.VarChar).Value = num;
            cmd.Parameters.Add("@fourth", OleDbType.VarChar).Value = res;
            cmd.Parameters.Add("@fifth", OleDbType.VarChar).Value = per;

            //...the values are set here.

            cmd.ExecuteNonQuery();

            //Excecute goes forth with the action.

            cmd.Parameters.Clear();

            //This clears the parameters to be used again.

            refillGrid();

            MessageBox.Show("Insertion Successful",
            "Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.ServiceNotification);

            LNameBox.Text = string.Empty;
            FNameBox.Text = string.Empty;
            phoneBox.Text = string.Empty;
            IPBox.Text = string.Empty;
            descBox.Text = string.Empty;
        }

        private void searchBox_TrailingIconClick(object sender, EventArgs e)
        {
            string search = searchBox.Text; //Variable used because Hynes likes them.

            DataTable tab = (DataTable)gridView.DataSource;

            DataView guys = tab.DefaultView;
            guys.RowFilter = "LName like '%" + search + "%'"; //Filters the LName column in search of what is in the search box (searchBox.Text).
        }

        private void prntBtn_Click(object sender, EventArgs e)
        {
            string gln = gridView.CurrentRow.Cells["LName"].Value.ToString();
            string gfn = gridView.CurrentRow.Cells["FName"].Value.ToString();
            string gnum = gridView.CurrentRow.Cells["PhoneNum"].Value.ToString();
            string gres = gridView.CurrentRow.Cells["Residence"].Value.ToString();
            string gper = gridView.CurrentRow.Cells["Prescription"].Value.ToString();

            //Turns all the values of the selected row into variables for later use.

            iTextSharp.text.Document doc = new iTextSharp.text.Document();
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 20, iTextSharp.text.Font.BOLD);

            //Sets fonts for the PDF file.

            Paragraph header = new Paragraph("Perscription", font);
            Paragraph lastD = new Paragraph("Last Name: " + gln, font);
            Paragraph firstD = new Paragraph("First Name: " + gfn, font);
            Paragraph numD = new Paragraph("Phone Number: " + gnum, font);
            Paragraph resD = new Paragraph("Address: " + gres, font);
            Paragraph perD = new Paragraph("Prescription and Comments: " + gper, font);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + gfn + " " + gln + "'s Information.pdf", FileMode.Create));
            doc.SetPageSize(new iTextSharp.text.Rectangle(this.Size.Width + doc.LeftMargin + doc.RightMargin, this.Size.Height + doc.TopMargin + doc.BottomMargin));

            //Sets up how the document will look.

            doc.Open();

            //Opens the doc.

            doc.Add(header);
            doc.Add(lastD);
            doc.Add(firstD);
            doc.Add(numD);
            doc.Add(resD);
            doc.Add(perD);

            //Adds all of the paragraphs made prior.

            doc.Close();

            //Closes the doc.

            MessageBox.Show("Print Successful.",
                   "Success!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information,
                   MessageBoxDefaultButton.Button1);
        }
    }
}

