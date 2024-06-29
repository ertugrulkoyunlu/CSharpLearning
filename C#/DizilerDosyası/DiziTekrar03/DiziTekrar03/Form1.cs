using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiziTekrar03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] sayilar = { 1.23, 8.15, 3.23, 4.32, 5.32, 5, 2, 1, 3 };
            int eleman = sayilar.Length;
            label1.Text = eleman.ToString();
        }
    }
}
