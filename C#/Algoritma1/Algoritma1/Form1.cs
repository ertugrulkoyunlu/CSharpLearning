using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritma1
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
            for(int i = 1 ; i<50 ; i++)
            {
                if(i %7 ==0)
                {
                    bolunensayisi ++;
                    label1.Text = bolunensayisi. ToString();
                    toplam = toplam + i;
                    label2.Text = toplam.ToString();
                    listBox1.Items.Add(label2.Text);
                }
            }
        }
    }
}
