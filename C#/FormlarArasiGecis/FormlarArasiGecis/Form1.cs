﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormlarArasiGecis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "patates" && textBox2.Text == "sifre")
            {
                Form2 frm = new Form2();
                frm.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlis sife veya kullanici adi girisi yaptiniz");
            }
        }
    }
}
