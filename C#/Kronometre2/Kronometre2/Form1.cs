using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronometre2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int saniye = Convert.ToInt32(label3.Text);
            int dakika = Convert.ToInt32(label2.Text);
            int saat = Convert.ToInt32(label1.Text);

            saniye++;

            label3.Text = Convert.ToString(saniye);


            if (saniye > 60)
            {
                dakika++;
                label2.Text = Convert.ToString(dakika);
                label3.Text = "0";
            }
            if (dakika > 60)
            {
                saat++;
                label1.Text = Convert.ToString(saat);
                label2.Text = "0";
            }

        }
    }
}
