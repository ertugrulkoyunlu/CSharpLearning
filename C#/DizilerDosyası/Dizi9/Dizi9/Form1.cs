﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dizi9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isim = new string[10];
        string[] ilce = new string[10];
        string[] telefon = new string[10];
        int i = 0;
        void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            isim[i] = textBox1.Text;
            ilce[i] = textBox2.Text;
            telefon[i] = textBox3.Text;
            i++;
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i--;
            label7.Text = isim[i];
            label8.Text = ilce[i];
            label9.Text = telefon[i];

        }

        private void button3_Click(object sender, EventArgs e)
        {
            i++;
            label7.Text = isim[i];
            label8.Text = ilce[i];
            label9.Text = telefon[i];
        }
    }
}
