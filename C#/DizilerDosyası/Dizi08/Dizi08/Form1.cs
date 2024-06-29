using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dizi08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayilar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            Array.Sort(sayilar);
            label1.Text = sayilar[sayilar.Length - 1].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayilar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            Array.Sort(sayilar);
            label4.Text = sayilar[0].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayilar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            int toplam = 0;
            foreach (int sayi in sayilar)
            {
                toplam += sayi;
                label6.Text = toplam.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayilar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            int toplam = 0;
            foreach (int sayi in sayilar)
            {
                toplam += sayi;

            }
            label8.Text = (toplam / sayilar.Length).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayilar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            foreach (int sayi in sayilar)
            {
                if (sayi % 2 == 0)
                {
                    listBox2.Items.Add(sayi);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayilar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            foreach (int sayi in sayilar)
            {
                if (sayi % 2 == 1)
                {
                    listBox3.Items.Add(sayi);
                }
            }
        }
    }
}
