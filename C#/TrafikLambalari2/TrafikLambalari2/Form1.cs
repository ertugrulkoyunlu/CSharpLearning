using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafikLambalari2
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
            button1.BackColor = Color.Red;

        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(label1.Text);
            int c = Convert.ToInt32(label1.Text);
            int d = Convert.ToInt32(label1.Text);
            i++;
            c++;
            d++;
            label1.Text = i.ToString();
            label1.Text = c.ToString();
            label1.Text = d.ToString();
            if (i == 1)
            {
                button1.BackColor = Color.Red;
            }
            if (c == 15)
            {
                button2.BackColor = Color.Yellow;
                button1.BackColor = Color.White;
            }
            if (d == 30)
            {
                button3.BackColor = Color.Green;
                button2.BackColor = Color.White;

            }
            if (d == 60)
            {
                label1.Text = Convert.ToString("0");
                button3.BackColor = Color.White;

            }

        }


    }
}
