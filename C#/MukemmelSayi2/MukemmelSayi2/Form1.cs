using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MukemmelSayi2
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
            int sayi1 = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i <= sayi1 / 2; i++)
            {
                if (sayi1 % i == 0)
                {
                    toplam = toplam + i;
                    listBox1.Items.Add(sayi1);
                    listBox2.Items.Add(toplam);
                }
                if (sayi1 == toplam)
                {
                    label1.Text = "Mukkemmel sayidir";
                }
                else
                {
                    label1.Text = "Mukemmel sayi degildir"; 
                }
            }
        }
    }
}
