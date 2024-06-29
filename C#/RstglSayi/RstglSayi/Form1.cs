using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RstglSayi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int gs = 0;
        int fb = 0;
        int ts = 0;
        int bjk = 0;
        int d = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            d = d + 1;
            textBox1.Text = d.ToString();
            if (d > 5)
            {
                button1.Enabled = false;
                button2.Visible = true;
            }


            int a = rnd.Next(0, 5);
            int b = rnd.Next(0, 5);


            label1.Text = a.ToString();
            label2.Text = b.ToString();

            if (Convert.ToInt32(label1.Text) > Convert.ToInt32(label2.Text))
            {
                gs = gs + 3;
                label7.Text = Convert.ToString(gs);
                //axWindowsMediaPlayer1;
            }
            else if (Convert.ToInt32(label1.Text) == Convert.ToInt32(label2.Text))
            {
                gs = gs + 1;
                label7.Text = Convert.ToString(gs);

            }
            if (Convert.ToInt32(label1.Text) < Convert.ToInt32(label2.Text))
            {
                fb = fb + 3;
                label8.Text = Convert.ToString(fb);
            }
            else if (Convert.ToInt32(label1.Text) == Convert.ToInt32(label2.Text))
            {
                fb = fb + 1;
                label8.Text = Convert.ToString(fb);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(label7.Text) > Convert.ToInt32(label8.Text))
            {
                label1.Text = "Galatasaray Kazandı";
            }
            else if (Convert.ToInt32(label7.Text) == Convert.ToInt32(label8.Text))
            {
                label1.Text = "Berabere";
            }
            else if (Convert.ToInt32(label7.Text) < Convert.ToInt32(label8.Text))
            {
                label1.Text = "Fenarbahçe Kazandı";
            }
        }
    }
}
