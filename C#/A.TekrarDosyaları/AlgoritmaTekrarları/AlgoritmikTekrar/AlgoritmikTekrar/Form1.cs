﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmikTekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int ctoplam = 0;
        int ttoplam = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);

            if (sayi1 % 2 == 0)
            {
                ctoplam = ctoplam + sayi1;
                label4.Text = ctoplam.ToString();
            }
            if (sayi1 % 2 == 1)
            {
                ttoplam = ttoplam + sayi1;
                label3.Text = ttoplam.ToString();
            }
        }
    }
}
