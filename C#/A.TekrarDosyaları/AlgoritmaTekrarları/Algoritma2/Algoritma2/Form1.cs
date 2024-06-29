using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritma2
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
            int sayi=Convert.ToInt32(textBox1.Text);
            textBox1.Text = Convert.ToString(sayi);

            for (int i = 1; i <= sayi / 2; i++)
            {
                if (sayi % 2 == 0)
                {
                    toplam = toplam + i;
                    listBox1.Items.Add(i);
                    listBox2.Items.Add(toplam);
                    listBox3.Items.Add(sayi);
                }
                if (sayi == toplam)
                {
                    label2.Text = "Mukemmel sayidir";
                }
                else
                {
                    label2.Text = "Mukemmel sayi degildir"; 
                }
            }
        }
    }
}
