using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KayitDefteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text;
            label4.Text = textBox2.Text;
            label6.Text = textBox3.Text;
            comboBox2.Items.Add("Istanbul");
            comboBox2.Items.Add("Adana");
            comboBox2.Items.Add("Mersin");
            label8.Text = comboBox1.Text;
            label10.Text = textBox4.Text;
        }
    }
}
