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
            DataTable tab = (DataTable)gridView.DataSource;

            DataRow row = tab.NewRow();

            int id = tab.Rows.Count + 1;
            string ln = lNameBox.Text;
            string fn = NameBox.Text;
            string num = phoneBox.Text;
            string res = IPBox.Text;
            string per = descBox.Text;

            row[0] = id;
            row[1] = ln;
            row[2] = fn;
            row[3] = num;
            row[4] = res;
            row[5] = per;

            tab.Rows.Add(row);

            cmd.ExecuteNonQuery();
            refillGrid();
            //MessageBox.Show("Insertion Successful",
            //     "Success",
            //     MessageBoxButtons.OK,
            //     MessageBoxIcon.Information,
            //     MessageBoxDefaultButton.Button1,
            //     MessageBoxOptions.ServiceNotification);
        }

        private void searchBox_LeadingIconClick(object sender, EventArgs e)
        {

        }

        private void searchBox_TrailingIconClick(object sender, EventArgs e)
        {
            string search = searchBox.Text;
            try
            {
                foreach (DataGridViewRow row in gridView.Rows)
                {
                    if (row.Cells[1].Value.ToString().Contains(search))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("That patient doesn't exist.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.ServiceNotification);
            }
        }

        private void prntBtn_Click(object sender, EventArgs e)
        {
            //string Name = NameBox.Text;
            //string lastnName = lNameBox.Text;
            //string phoneNumber = phoneBox.Text;
            //string address = IPBox.Text;
            //string prescription = string.Join("\n", gridView.Rows.Cast<DataGridViewRow>()
            //    .Select(row => row.Cells["PrescriptionColumn"].Value.ToString()));

            //using (var PdfWritter = new PdfWriter("Prescription.pdf"))
            //{
            //    using (var pdf = new PdfDocument(PdfWriter))
            //    {
            //        var document = new document(pdf);

            //        document.Add(new Paragraph($"Name: {Name} {lastnName} \nPhone Number: {phoneNumber} \nAddress: {address} \n\nPrescription Information: \n{prescription}"));

                    
                        
            //    }
            //}
            //MessageBox.Show("Prescription generated successfully");

        }
    }
}

