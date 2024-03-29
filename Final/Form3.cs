﻿using System;
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
            MaximizeBox = false;
            SoundPlayer Die = new System.Media.SoundPlayer(Properties.Resources.Die);
            Die.Play();
            backgroundWorker1.RunWorkerAsync();

            //Plays the sound of Austin's mandatory message.
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(21710);
            this.Close();

            //Waits for the exact amount of time in the sound file and then closes it.
        }
    }
}
