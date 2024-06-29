using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemeBiletSatis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int seans1 = 0;
        int seans1ucret = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            seans1++;
            seans1ucret += 8;
            textBox1.Text = seans1.ToString();
            textBox2.Text = seans1ucret.ToString();
            if (seans1 == 30)
            {
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            seans1--;
            seans1ucret -= 8;
            textBox1.Text = seans1.ToString();
            textBox2.Text = seans1ucret.ToString();
        }
    }
}
