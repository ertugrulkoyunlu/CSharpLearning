using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatamatikTahmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int sayac = 30;

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = false;

            int sayi1, sayi2, islem;
            int a;
            sayi1 = rnd.Next(0, 51);
            sayi2 = rnd.Next(0, 51);
            islem = rnd.Next(1, 5);


            if (islem == 1)
            {
                label4.Text = "+";
                a = sayi1 + sayi2;
                label3.Text = a.ToString();
            }
            if (islem == 2)
            {
                label4.Text = "-";
                a = sayi1 - sayi2;
                label3.Text = a.ToString();
            }

            if (islem == 3)
            {
                label4.Text = "/";
                a = sayi1 / sayi2;
                label3.Text = a.ToString();
            }
            if (islem == 4)
            {
                label4.Text = "*";
                a = sayi1 * sayi2;
                label3.Text = a.ToString();
            }
            label1.Text = sayi1.ToString();
            label2.Text = sayi2.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            int puan = Convert.ToInt32(label6.Text);
            label3.Visible = false;
            if (Convert.ToString(textBox1.Text) == Convert.ToString(label3.Text))
            {
                puan += 10;
                label6.Text = puan.ToString();
            }
            button1.PerformClick();

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = sayac.ToString();
            sayac--;

            button1.Visible = true;
            button2.Visible = true;
            if (sayac == -1)
            {
                button1.Visible = false;
                button2.Visible = false;
                sayac = 30;
                timer1.Stop();
                button4.Visible = true;

            }


        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            textBox1.Focus();
            button1.PerformClick();
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            button2.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button4.Visible = false;
            textBox1.Focus();

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                button2.PerformClick();
                textBox1.Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
        }
    }
}
