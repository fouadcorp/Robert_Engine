﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robert_Engine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            wait(random.Next(500,800));
            label1.Text = "Initializing assets";
            wait(random.Next(250, 380));
            label1.Text = "Initializing scripts";
            wait(random.Next(400,690));
            label1.Text = "Waiting for robert";
            wait(random.Next(300,900));
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
            form2.FormClosed += new FormClosedEventHandler(form2_FormClosed);

        }

    }
}
