using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritma0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int toplam1 = 0;
        int toplam2 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int a;

            a = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i < a; i++)
            {
                if (a % 2 == 0)
                {
                    toplam1 = a+ toplam1; 

                    label3.Text = Convert.ToString(toplam1);
                }
                if (a % 2 == 1)
                {
                    toplam2 = a + toplam2;


                }
            }
        }
    }
}
