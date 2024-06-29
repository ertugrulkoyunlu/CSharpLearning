using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int  sayi1, sayi2, sonuc;

            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            sonuc = sayi1 + sayi2;

            label3.Text = Convert.ToString(sonuc);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt32(textBox4.Text);
            sayi2 = Convert.ToInt32(textBox3.Text);
            sonuc = sayi1 - sayi2;

            label7.Text = Convert.ToString(sonuc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt32(textBox6.Text);
            sayi2 = Convert.ToInt32(textBox5.Text);
            sonuc = sayi1 * sayi2;

            label4.Text = sonuc.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt32(textBox8.Text);
            sayi2 = Convert.ToInt32(textBox7.Text);
            sonuc = sayi1 / sayi2;

            label10.Text = sonuc.ToString();
        }
    }
}
