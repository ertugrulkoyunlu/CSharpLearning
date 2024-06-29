using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmaTekrar4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tektoplam = 0;
        int cifttoplam = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);

            if (sayi % 2 == 0)
            {
                cifttoplam = cifttoplam + sayi;
                label4.Text = cifttoplam.ToString();
            }
            if (sayi % 2 == 1)
            {
                tektoplam = tektoplam + sayi;
                label3.Text = tektoplam.ToString();
            }
        }
    }
}
