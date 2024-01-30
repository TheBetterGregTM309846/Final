using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.OleDb;

namespace Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Austin Morrison-Prieur
            //Gregory Buckley
            //Gregory Hynes
            //Mann Talati

            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\final.accdb")); //Checks for final.accdb on every system.

            conn.Open();
            OleDbCommand cmd = new OleDbCommand("select * from users", conn);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            cmd.ExecuteNonQuery();
            conn.Close();

            nameCBox.DataSource = ds.Tables[0];
            nameCBox.DisplayMember = "Username";
            nameCBox.ValueMember = "Username";
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\final.accdb")); //Checks for final.accdb on every system.
            conn.Open(); // opens connection to the database.

            OleDbCommand command = new OleDbCommand("SELECT * FROM users where Username='" + nameCBox.Text + "' and Password='" + passBox.Text + "'", conn); // creates the command to check the database for the password.
            command.ExecuteNonQuery(); // executes a non-query command, or one that doesn't return a set of rows.

            OleDbDataReader reader = command.ExecuteReader(); // creates an oledb reader to read the database.
            if (reader.Read() == true) // if it can see something that matches then...
            {
                if (nameCBox.Text != "Austin Morrison-Prieur")
                {
                    string user = nameCBox.Text; // Creates a variable to be used to display username on the second form.
                    Form2 TBD = new Form2(user); // Passes said variable.
                    this.Hide(); // Used to hide the first form.
                    TBD.ShowDialog(); // Used to display the second form.
                }
                else
                {
                    Form3 Loggus = new Form3(); // Passes said variable.
                    this.Hide(); // Used to hide the first form.
                    Loggus.ShowDialog(); // Used to display the second form.
                }
            }
            else { MessageBox.Show("Wrong password, try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); } // if not it must be the wrong password.

            conn.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string user = nameCBox.Text; // Creates a variable to be used to display username on the second form.
            Form2 TBD = new Form2(user); // Passes said variable.
            this.Hide(); // Used to hide the first form.
            TBD.ShowDialog(); // Used to display the second form.
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked == true)
            {
                passBox.PasswordChar = '\0';
            }
            else { passBox.PasswordChar = '●'; }
        }
    }
}