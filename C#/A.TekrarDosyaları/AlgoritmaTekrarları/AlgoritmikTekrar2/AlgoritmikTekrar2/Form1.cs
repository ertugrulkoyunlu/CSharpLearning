using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmikTekrar2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int bolunensayisi = 0;
        int toplam = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <50; i++)
            {
                if (i %7 == 0)
                {
                    bolunensayisi++;
                    label2.Text = bolunensayisi.ToString();
                    toplam += i;
                    label4.Text =toplam.ToString();
                    listBox1.Items.Add(label4.Text);
                }
            }
        }
    }
}
