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
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string user = nameCBox.Text; // Creates a variable to be used to display username on the second form.
            Form2 TBD = new Form2(user); // Passes said variable.
            this.Hide(); // Used to hide the first form.
            TBD.ShowDialog(); // Used to display the second form.
        }
    }
}