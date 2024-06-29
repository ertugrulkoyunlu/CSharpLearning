using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            int atgenislik1 = pictureBox1.Width;
            int atgenislik2 = pictureBox2.Width;
            int atgenislik3 = pictureBox3.Width;
            int sayac = Convert.ToInt32(label8.Text);
            int bitis = label4.Left;

            sayac++;
            label8.Text = Convert.ToString(sayac);
            pictureBox1.Left += rnd.Next(5, 10);
            pictureBox2.Left += rnd.Next(5, 10);
            pictureBox3.Left += rnd.Next(5, 10);

            if (pictureBox1.Left > pictureBox2.Left && pictureBox1.Left > pictureBox3.Left)
            {
                label7.Text = "birinci at onde";
            }
            if (pictureBox2.Left > pictureBox1.Left && pictureBox2.Left > pictureBox3.Left)
            {
                label7.Text = "ikinci at onde";
            }
            if(pictureBox3.Left > pictureBox1.Left && pictureBox3.Left > pictureBox2.Left)
            {
                label7.Text = "ucuncu at onde";            
            }


            if (atgenislik1 + pictureBox1.Left >= bitis)
            {
                timer1.Enabled = false;
                label7.Text = ("birinci at yarisi kazandi");
            }
            if (atgenislik2 + pictureBox2.Left >= bitis)
            {
                timer1.Enabled = false;
                label7.Text = ("ikinci at yarisi kazandi");
            }
            if (atgenislik3 + pictureBox3.Left >= bitis)
            {
                timer1.Enabled = false;
                label7.Text = ("ucuncu at yarisi kazandi");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
