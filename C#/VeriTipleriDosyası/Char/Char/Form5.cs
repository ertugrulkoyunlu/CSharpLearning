﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Char
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        int toplam = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string cumle = textBox1.Text;
            char harf = Convert.ToChar(textBox2.Text);


            foreach (char i in cumle)
            {
                if (harf == i)
                {
                    toplam++;

                }

            }
            label1.Text = toplam.ToString();
        }
    }
}
