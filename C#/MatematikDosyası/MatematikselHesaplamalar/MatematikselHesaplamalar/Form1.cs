using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatematikselHesaplamalar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            int birkenar;
            int alan, cevre;

            birkenar = Convert.ToInt32(textBox1.Text);
            alan = birkenar * birkenar;
            cevre = birkenar * 4;

            label4.Text = Convert.ToString(alan);
            label5.Text = Convert.ToString(cevre);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label7.Visible = false;
            textBox2.Visible = false;
            label1.Text = "Kare";
            label8.Visible = false;
            button4.Visible = true;
            button5.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Text = "Dikdortgen";
            label8.Text = "Kisa Kenari giriniz";
            button5.Visible = true;
            button4.Visible = false;
            label7.Visible = true;
            textBox2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int kisa, uzun;
            int alan, cevre;

            kisa = Convert.ToInt32(textBox1.Text);
            uzun = Convert.ToInt32(textBox2.Text);

            alan = kisa * uzun;
            cevre = (2 * kisa) + (2 * uzun);

            label4.Text = Convert.ToString(alan);
            label5.Text = Convert.ToString(cevre);
        }
    }
}
