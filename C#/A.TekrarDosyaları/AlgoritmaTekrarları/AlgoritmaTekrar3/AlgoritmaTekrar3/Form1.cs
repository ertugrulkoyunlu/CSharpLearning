using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmaTekrar3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            int toplam = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi=0;
            for (int i = 1; i < 50; i++)
            {
                if (i % 7 == 0)
                {
                    sayi++;
                    label3.Text = sayi.ToString();
                    listBox1.Items.Add(sayi);
                    listBox2.Items.Add(i);
                    toplam = toplam + i;
                    label4.Text = toplam.ToString();
                    listBox3.Items.Add(toplam);
                    }
            }
        }
    }
}
