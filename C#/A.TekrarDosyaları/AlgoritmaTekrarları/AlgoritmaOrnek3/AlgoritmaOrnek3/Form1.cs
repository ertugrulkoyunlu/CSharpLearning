using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmaOrnek3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int sayi;
            sayi = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i <= sayi / 2; i++)
            {
                if (sayi % i == 0)
                {
                    toplam = toplam + i;
                    listBox1.Items.Add(toplam);
                }
                if (sayi == toplam)
                {
                    label2.Text = "MUKEMMEL SAYIDIR";
                }
                else
                { 
                    label2.Text = "mukemmel sayi degildir";
                }
            }
        }
    }
}
