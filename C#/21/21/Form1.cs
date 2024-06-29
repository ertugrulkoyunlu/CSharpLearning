using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int sayac = 0;
        int opuan = 0;
        int bpuan = 0;
        private bool button1WasClicked = false;
        private bool button2WasClicked = false;
        private void button1_Click(object sender, EventArgs e)
        {
            sayac++;
            button1WasClicked = true;
if (button2WasClicked)
            {
                button3.Visible = true;
                button4.Visible = true;
            }
            if (sayac == 1)
            {
                int a1, a2, toplam;
                a1 = rnd.Next(1, 11);
                a2 = rnd.Next(1, 11);
                toplam = a1 + a2;
                label1.Text = a1.ToString();
                label2.Text = a2.ToString();
                label10.Text = toplam.ToString();
            }
            if (sayac == 2)
            {
                int a3, toplam;
                a3 = rnd.Next(1, 11);
                label3.Text = a3.ToString();
                toplam = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + a3;
                label10.Text = toplam.ToString();
            }
            if (sayac == 3)
            {
                int a4, toplam;
                a4 = rnd.Next(1, 11);
                label4.Text = a4.ToString();
                toplam = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + Convert.ToInt32(label3.Text) + a4;
                label10.Text = toplam.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2WasClicked = true;
            if (button1WasClicked)
            {
                button3.Visible = true;
                button4.Visible = true;
            }
            int b1, b2, toplam;
            b1 = rnd.Next(1, 11);
            b2 = rnd.Next(1, 11);
            toplam = b1 + b2;
            label5.Text = b1.ToString();
            label6.Text = b2.ToString();
            label12.Text = toplam.ToString();
            if (b1 + b2 < 16)
            {
                int b3;
                b3 = rnd.Next(1, 11);
                label7.Text = b3.ToString();
                toplam = toplam + b3;
                label12.Text = toplam.ToString();
            }
            if (toplam < 16)
            {
                int b4;
                b4 = rnd.Next(1, 11);
                label8.Text = b4.ToString();
                toplam = toplam + b4;
                label12.Text = toplam.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button4.Enabled = true;



            int otoplam, btoplam;
            otoplam = Convert.ToInt32(label10.Text);
            btoplam = Convert.ToInt32(label12.Text);

            if (otoplam > btoplam && otoplam <= 21)
            {
                opuan += 10;
                label15.Text = opuan.ToString();
                label13.Text = "birinci oyuncu kazandi";
            }
            if (btoplam > otoplam && btoplam <= 21)
            {
                bpuan += 10;
                label17.Text = bpuan.ToString();
                label13.Text = "bilgisayar kazandi";
            }
            if (btoplam > 21 && otoplam > 21)
            {
                MessageBox.Show("Degerler buyuk Beraberlik");
            }
            if (btoplam == otoplam && btoplam <= 21 && otoplam <= 21)
            {
                bpuan += 10;
                opuan += 10;
                label15.Text = opuan.ToString();
                label17.Text = bpuan.ToString();
            }
            if (btoplam <= 21 && otoplam >= 21)
            {
                bpuan += 10;
                label17.Text = bpuan.ToString();
                label13.Text = "bilgisayar kazandi";
            }
            if (otoplam <= 21 && btoplam >= 21)
            {
                opuan += 10;
                label15.Text = opuan.ToString();
                label13.Text = "birinci oyuncu kazandi";
            }
            if (opuan == 50)
            {
                MessageBox.Show("Kazandiniz");
            }
            if (bpuan == 50)
            {
                MessageBox.Show("Kaybettiniz ");
            }
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label5.Text == "0")
            {
                button3.Visible = false;
                button4.Visible = false;
            }
            button4.Enabled = false;
            button3.Enabled = true;
            sayac = 0;
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
            label7.Text = "0";
            label8.Text = "0";
            label10.Text = "0";
            label12.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label5.Text == "0")
            {
                button3.Visible = false;
                button4.Visible = false;
            }

        }
    }
}
