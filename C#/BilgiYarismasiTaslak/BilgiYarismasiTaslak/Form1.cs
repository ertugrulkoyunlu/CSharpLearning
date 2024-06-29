using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarismasiTaslak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "adsad";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "yanlis yaptiniz";
        }
        int i = 0;
        private void button5_Click(object sender, EventArgs e)
        {

            i++;
            label2.Text = Convert.ToString(i);
            if (i ==1)
            {
                richTextBox1.Text = "fsda";
            }
            if(i==2)
            {
                richTextBox1.Text = "patates";
            }
        }
    }
}
