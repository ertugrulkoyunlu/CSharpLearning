using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafikLambalari
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            int yesil = Convert.ToInt32(label1.Text);
            int sari = Convert.ToInt32(label1.Text);
            int kirmizi = Convert.ToInt32(label1.Text);
            sari++;
            yesil++;
            kirmizi++;
            label1.Text = yesil.ToString();
            label1.Text = sari.ToString();
            label1.Text = kirmizi.ToString();
            if (kirmizi == 1)
            {
                
                button1.BackColor = Color.Red;
                button3.BackColor = Color.White;
            }
            if (sari == 15)
            {
                
                button2.BackColor = Color.Yellow;
                button1.BackColor = Color.White;

            }
            if (yesil == 30)
            {
              
                button3.BackColor = Color.Green;
                button2.BackColor = Color.White;

            }
            if (yesil == 60)
            {
                label1.Text = Convert.ToString(0);
                button3.BackColor = Color.White;
            }
        }
    }
}
