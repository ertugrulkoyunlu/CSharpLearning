using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYaris3
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
            int sayac = Convert.ToInt32(label6.Text);
            int genislik1 = pictureBox1.Width;
            int genislik2 = pictureBox2.Width;
            int genislik3 = pictureBox3.Width;

            sayac++;
            label6.Text = Convert.ToString(sayac);
            
            if (pictureBox1.Left > pictureBox2.Left && pictureBox1.Left > pictureBox3.Left)
            {
                label7.Text = "birinci at onde";
            }
            
            if (pictureBox2.Left > pictureBox1.Left && pictureBox2.Left > pictureBox3.Left)
            {
                label7.Text = "ikinci at onde";
            }
            
            if (pictureBox3.Left > pictureBox2.Left && pictureBox3.Left > pictureBox1.Left)
            {
                label7.Text = "ucuncu at onde";
            }
            if (genislik1 + pictureBox1.Left < label5.Left)
            {
                pictureBox1.Left += rnd.Next(5, 10);

            }
            else
            {
                timer1.Enabled = false;
                label7.Text = "birinci at kazandi ";
            }



            if (genislik2 + pictureBox2.Left < label5.Left)
            {
                pictureBox2.Left += rnd.Next(5, 10);
            }
            else
            {
                timer1.Enabled = false;
                label7.Text = "ikinci at kazandi ";
            }
            if (genislik3 + pictureBox3.Left < label5.Left)
            {
                pictureBox3.Left += rnd.Next(5, 10);
            }
            else
            {
                timer1.Enabled = false;
                label7.Text = "ucuncu at kazandi ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
