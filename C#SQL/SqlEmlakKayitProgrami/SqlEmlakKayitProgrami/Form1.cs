﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlEmlakKayitProgrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "siteadmin"&& textBox2.Text == "site12345")
            {
                this.Hide(); 
                Form2 frm2 = new Form2();
                frm2.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                this.Hide(); 
                Form2 frm2 = new Form2();
                frm2.ShowDialog();
        }
    }
}
