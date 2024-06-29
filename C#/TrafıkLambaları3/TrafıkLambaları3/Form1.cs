using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafıkLambaları3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int kirmizi= Convert.ToInt32(label1.Text);
            int sari = Convert.ToInt32(label1.Text);
            int yesil = Convert.ToInt32(label1.Text);
            sari++;
            kirmizi++;
            yesil++;
            label1.Text = kirmizi.ToString();
            label1.Text = sari.ToString();
            if(kirmizi==1)
            {
                button1.BackColor=Color.Red;
            }
            if(sari==15)
            {
                button2.BackColor=Color.Yellow;
                button1.BackColor=Color.White;
            }
            if(yesil==30)
            {
                button3.BackColor=Color.Green;
                button2.BackColor=Color.White;
            }
            if(yesil==45)
            {
                label1.Text ="0";
                button3.BackColor=Color.White;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BackColor =Color.Red;
        }
    }
}
