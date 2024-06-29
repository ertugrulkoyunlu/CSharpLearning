using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsVeKarekok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2;
            double us;

            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);

            us = Math.Pow(sayi1, sayi2);
            label1.Text = Convert.ToString(us);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double sayi3;
            double karekok;
            
            sayi3 = Convert.ToDouble(textBox3.Text);
            karekok = Math.Sqrt(sayi3); 
            label2.Text = Convert.ToString(karekok);
        }
    }
}
