using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpDersTekrar3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private bool sag = true;
        private bool asagi = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            int genislik = pictureBox1.Width;
            int uzunluk = pictureBox1.Height;
            int altbitis = label1.Top;
            int sagbitis = label2.Left;
            int ustbitis = label3.Bottom;
            int solbitis = label4.Right;

            if (asagi)
            {
                if (uzunluk + pictureBox1.Top < altbitis)
                {
                    pictureBox1.Top += 10;
                }
                else
                {
                    asagi = false;
                }
            }
            else
            {
                if (pictureBox1.Top > ustbitis)
                {
                    pictureBox1.Top -= 10;
                }
                else
                {
                    asagi = true;
                }
            }
            if (sag)
            {
                if (genislik + pictureBox1.Left < sagbitis)
                {
                    pictureBox1.Left +=10;
                }
                else
                {
                    sag=false;
                }
            }
            else
            {
                if(pictureBox1.Left >solbitis)
                {
                    pictureBox1.Left-=10;
                }
                else
                {
                    sag=true;
                }
            }


        }
    }
}
