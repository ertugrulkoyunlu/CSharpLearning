using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TekCiftToplam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int cifttoplam=0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            int sayi = Convert.ToInt32(textBox1.Text);
            if (sayi % 2 == 0)
            {
                cifttoplam=  sayi + cifttoplam;
                label2.Text = cifttoplam.ToString();
            }
        }
    }
}
