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
            /*if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("The Caps Lock key is ON.");
            }
            else
            {
                MessageBox.Show("The Caps Lock key is OFF.");
            }*/
        }
    }
}