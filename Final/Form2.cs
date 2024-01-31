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

        private void fNameBox_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close(); //Closes every relating form.
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gridView.SelectedRows)
            {
                gridView.Rows.RemoveAt(this.gridView.SelectedRows[0].Index);
            }
            updateBtn_Click(sender, e);

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
            cmd.Parameters.Add("@first", OleDbType.VarChar).Value = ln;
            cmd.Parameters.Add("@second", OleDbType.VarChar).Value = fn;
            cmd.Parameters.Add("@third", OleDbType.VarChar).Value = num;
            cmd.Parameters.Add("@fourth", OleDbType.VarChar).Value = res;
            cmd.Parameters.Add("@fifth", OleDbType.VarChar).Value = per;
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            refillGrid();

            MessageBox.Show("Insertion Successful",
            "Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.ServiceNotification);
        }

        private void searchBox_LeadingIconClick(object sender, EventArgs e)
        {

        }

        private void searchBox_TrailingIconClick(object sender, EventArgs e)
        {
            string search = searchBox.Text;


            /*
            foreach (DataGridViewRow row in gridView.Rows)
            {
                row.Visible = false;
                if (row.Cells[1].Value.ToString().Contains(search))
                {
                    row.Visible = true;
                    break;
                }
            }*/
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
            doc.Add(header);
            doc.Add(lastD);
            doc.Add(firstD);
            doc.Add(numD);
            doc.Add(resD);
            doc.Add(perD);
            doc.Close();

            //Adds all the variables from before to the doccument and then closes it.

            MessageBox.Show("Print Successful.",
                   "Success!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information,
                   MessageBoxDefaultButton.Button1);

            //Reminder to change "perscription" to "prescription" in base table and then upload said table to GitHub. Also a reminder to update all the WinForm Lessons and upload the code to Drive.
        }
    }
}

