using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciKayitRehberi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            label1.Text = "deneme dunyasina";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text ="c# dili derslerine hosgeldiniz";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "deneme deneme";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = textBox2.Text; 
        }
    }
}
