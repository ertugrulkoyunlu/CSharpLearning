using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpDersTekrar2
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
        private bool sagadogru = true;
        private bool asagidogru = true;
        private void timer1_Tick(object sender, EventArgs e)
        {

            int genislik = pictureBox1.Width;
            int uzunluk = pictureBox1.Height;
            int altbitis = label1.Top;
            int ustbitis = label3.Bottom;
            int solbitis = label4.Right;
            int sagbitis = label2.Left;
            if (asagidogru)
            {
                if (uzunluk + pictureBox1.Top <= altbitis)
                {
                    pictureBox1.Top += 10;
                }
                else
                {
                    asagidogru = false;
                }
            }
            else
            {
                if (pictureBox1.Top >= ustbitis)
                {
                    pictureBox1.Top -= 10;
                }
                else
                {
                    asagidogru = true;
                }
            }
            if (sagadogru)
            {
                if (genislik + pictureBox1.Left <= sagbitis)
                {
                    pictureBox1.Left += 10;
                }
                else
                {
                    sagadogru = false;
                }
            }
            else
            {

                if (pictureBox1.Left >= solbitis)
                {
                    pictureBox1.Left -= 10;
                }
                else
                {
                    sagadogru = true;
                }



            }
        }
    }
}
