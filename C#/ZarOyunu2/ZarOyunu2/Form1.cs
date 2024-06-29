using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarOyunu2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {

            int sayi = Convert.ToInt32(label1.Text);
            int sayi2 = Convert.ToInt32(label2.Text);

            if (sayi > sayi2 )
            {
                label3.Text = "birinci oyuncu kazandi";
            }
            if(sayi2 > sayi)
            {
                label3.Text = "ikinci oyuncu kazandi";
            }


            if (sayi >= 1 && sayi < 6 || sayi2 >= 0 && sayi2 < 5)
            {
                sayi += rnd.Next(1, 5);
                sayi2 += rnd.Next(1, 5);
                label1.Text = Convert.ToString(sayi);
                label2.Text = Convert.ToString(sayi2);
            }
            if (sayi >=6 || sayi2 >= 6)
            {
                label1.Text = "0";
                label2.Text = "0";
            }
        }
    }
}
