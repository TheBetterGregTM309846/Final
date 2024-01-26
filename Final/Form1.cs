using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.OleDb;

namespace Final
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\final.accdb")); //Checks for final.accdb on every system.
        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;// set up the backgroundworker

            backgroundWorker1.RunWorkerAsync();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false; // Prevents fullscreen button from working.
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                forgor.Visible = true;
            }
            else
            {
                forgor.Visible = false;
            }

            //backgroundWorker1.DoWork();

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            /* if (nameCBox.SelectedIndex == 0 && passBox.Text == "7777777" || nameCBox.SelectedIndex == 1 && passBox.Text == "GregWasHere" || nameCBox.SelectedIndex == 2 && passBox.Text == "ImGay" || nameCBox.SelectedIndex == 2 && passBox.Text == "ImGay")
            {
                string user = nameCBox.Text; // Creates a variable to be used to display username on the second form.
                Form2 TBD = new Form2(user); // Passes said variable.
                this.Hide(); // Used to hide the first form.
                TBD.ShowDialog(); // Used to display the second form.
            }
            else { MessageBox.Show("Wrong password, try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); } */

            conn.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = conn;
            command.CommandText = "select * from users where Username=" +nameCBox.Text+" and Password= "+passBox.Text+"";
            command.ExecuteNonQuery();

            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read()) 
            {
                count++;

            }

            conn.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.CapsLock)
            {
                if (forgor.Visible == true)
                {
                    forgor.Visible = false;
                }
                else { forgor.Visible = true; }
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (true)
            {
                bool capsLockOn = Control.IsKeyLocked(Keys.CapsLock); // Check the caps lock status
                BeginInvoke(new Action(() =>// Update the label on the UI thread
                {
                    forgor.Text = capsLockOn ? "Caps Lock is On" : "";

                }));

                System.Threading.Thread.Sleep(100); // Sleep for a short interval
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.CapsLock)
            {
                if (forgor.Visible == true)
                {
                    forgor.Visible = false;
                }
                else { forgor.Visible = true; }
            }
        }
    }
}