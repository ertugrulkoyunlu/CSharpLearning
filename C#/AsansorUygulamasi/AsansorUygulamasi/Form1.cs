using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsansorUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label8.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label8.Text = "0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label8.Text == "1")
            {
                if (pictureBox1.Top >= label6.Top)
                {
                    pictureBox1.Top -= 5;
                }
            }
            if (label8.Text == "0")
            {
                if(pictureBox1.Top <= label5.Top) 
                {
                    pictureBox1.Top += 5;
                }
            }
        }
    }
}
