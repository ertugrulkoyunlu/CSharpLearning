using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RastgeleSayi
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
            int sayi = rnd.Next(1, 7);
            int sayi2 = rnd.Next(1, 7);
            label1.Text = sayi.ToString();
            label2.Text = sayi2.ToString();
            if (sayi > sayi2)
            {
                MessageBox.Show("1.Oyuncu kazandi");
            }

            else if (sayi == sayi2)
            {
                MessageBox.Show("Berabere");
            }
            
            else if (sayi < sayi2)
            {
                MessageBox.Show("2.Oyuncu kazandi");
            }
        }
    }
}
