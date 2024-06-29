using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MukemmelSayi
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

            int sayi = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i < sayi / 2; i++)
            {
                if (sayi % i == 0)
                {
                    toplam = toplam + i;
                }
                if (sayi == toplam)
                {
                    label1.Text = "Mukemmel sayidir";
                }
            }
        }
    }
}
