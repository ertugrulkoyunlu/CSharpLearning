using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaraftarTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int saniye = Convert.ToInt32(label1.Text);
            saniye++;
            label1.Text = Convert.ToString(saniye);
            if (saniye % 10 == 0)
            {
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Yellow;
                button3.BackColor = Color.Red;
            }
            if (saniye % 10 == 5)
            {
                button1.BackColor = Color.Yellow;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Yellow;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                timer1.Enabled = true;
            }
        }
    }
}
