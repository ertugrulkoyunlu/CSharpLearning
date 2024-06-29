using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModAlma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void button1_Click_1(object sender, EventArgs e)
        {
            int sayi1;
            int sayi2,mod;

            sayi1 = 60 % 16;
            label1.Text = sayi1.ToString();

            sayi2 = Convert.ToInt32(textBox1.Text);
            mod = 100 % sayi2;
            label2.Text = mod.ToString();
        }
    }
}
