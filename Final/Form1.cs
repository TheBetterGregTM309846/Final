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

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            backgroundWorker1.RunWorkerAsync();

            MaximizeBox = false; // Prevents fullscreen button from working.

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

            conn.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = conn;
            command.CommandText = "select * from users where Username=" + nameCBox.Text + " and Password= " + passBox.Text + "";
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

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
                 
                while (true)
                {
                    bool capsLockOn = Control.IsKeyLocked(Keys.CapsLock); // Check the caps lock status
                    BeginInvoke(new Action(() =>// Update the forgor on the UI thread
                    {
                        forgor.Text = capsLockOn ? "Caps Lock is On" : "";

                    }));

                    System.Threading.Thread.Sleep(100); // Sleep for a short interval
                }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string user = nameCBox.Text; // Creates a variable to be used to display username on the second form.
            Form2 TBD = new Form2(user); // Passes said variable.
            this.Hide(); // Used to hide the first form.
            TBD.ShowDialog(); // Used to display the second form.
        }

        
    }
}