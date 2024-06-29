using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritma1._1
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
            int bolunensayisi = 0;
            for (int i = 1; i < 50; i++)
            {
                if (i % 5 == 0)
                {
                    bolunensayisi++;
                    label3.Text = Convert.ToString(bolunensayisi);
                    toplam = toplam + i;
                    label4.Text = Convert.ToString(toplam);
                    listBox1.Items.Add(bolunensayisi);
                    listBox2.Items.Add(toplam);
                    listBox3.Items.Add(i);
                }
            }
        }
    }
}
