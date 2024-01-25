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

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string user = nameCBox.Text;
            Form2 TBD = new Form2(user);
            this.Hide();
            TBD.ShowDialog();

        }
    }
}