using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleAritmetikOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b;
            double toplam, fark, carpim, bolme;

            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);

            toplam = a + b;
            fark = a - b;
            carpim = a * b;
            bolme = a / b;

            label1.Text = Convert.ToString(toplam);
            label4.Text = Convert.ToString(fark);
            label6.Text = Convert.ToString(carpim);
            label8.Text = Convert.ToString(bolme);
        }
    }
}
