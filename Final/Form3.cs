using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SoundPlayer Die = new System.Media.SoundPlayer(Properties.Resources.Die);
            Die.Play();
            backgroundWorker1.RunWorkerAsync();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(21000);
            this.Close();
        }
    }
}
