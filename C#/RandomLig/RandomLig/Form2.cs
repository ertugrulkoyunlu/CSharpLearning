using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomLig
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int gspuan = 0;
        int fbpuan = 0;
        int bjkpuan = 0;
        int tspuan = 0;
        int i = 0;
        int j = 0;
        int h = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            i = i + 1;
            textBox1.Text = i.ToString();
            if (i > 1)
            {
                button1.Enabled = false;
            }
            int a = rnd.Next(0, 5);
            int b = rnd.Next(0, 5);
            int c = rnd.Next(0, 4);
            int d = rnd.Next(0, 4);
            label4.Text = a.ToString();
            label5.Text = b.ToString();
            label6.Text = c.ToString();
            label7.Text = d.ToString();

            if (Convert.ToInt32(label4.Text) > Convert.ToInt32(label5.Text))
            {
                gspuan = gspuan + 3;
                label13.Text = gspuan.ToString();
            }
            else if (Convert.ToInt32(label4.Text) == Convert.ToInt32(label5.Text))
            {
                gspuan = gspuan + 1;
                label13.Text = Convert.ToString(gspuan);
            }


            if (Convert.ToInt32(label4.Text) < Convert.ToInt32(label5.Text))
            {
                fbpuan = fbpuan + 3;
                label12.Text = fbpuan.ToString();
            }
            else if (Convert.ToInt32(label4.Text) == Convert.ToInt32(label5.Text))
            {
                fbpuan = fbpuan + 1;
                label12.Text = fbpuan.ToString();
            }


            if (Convert.ToInt32(label7.Text) > Convert.ToInt32(label6.Text))
            {
                bjkpuan = bjkpuan + 3;
                label11.Text = bjkpuan.ToString();
            }
            else if (Convert.ToInt32(label7.Text) == Convert.ToInt32(label6.Text))
            {
                bjkpuan = bjkpuan + 1;
                label11.Text = bjkpuan.ToString();
            }


            if (Convert.ToInt32(label7.Text) < Convert.ToInt32(label6.Text))
            {
                tspuan = tspuan + 3;
                label14.Text = tspuan.ToString();
            }
            else if (Convert.ToInt32(label7.Text) == Convert.ToInt32(label6.Text))
            {
                tspuan = tspuan + 1;
                label14.Text = tspuan.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            j = j + 1;
            textBox1.Text = j.ToString();
            if (j > 1)
            {
                button2.Enabled = false;
            }
            int a = rnd.Next(0, 5);
            int b = rnd.Next(0, 5);
            int c = rnd.Next(0, 4);
            int d = rnd.Next(0, 4);
            label21.Text = a.ToString();
            label18.Text = b.ToString();
            label22.Text = c.ToString();
            label15.Text = d.ToString();

            if (Convert.ToInt32(label21.Text) > Convert.ToInt32(label22.Text))
            {
                gspuan = gspuan + 3;
                label13.Text = gspuan.ToString();
            }
            else if (Convert.ToInt32(label21.Text) == Convert.ToInt32(label22.Text))
            {
                gspuan = gspuan + 1;
                label13.Text = gspuan.ToString();
            }

            if (Convert.ToInt32(label21.Text) < Convert.ToInt32(label22.Text))
            {
                bjkpuan = bjkpuan + 3;
                label11.Text = bjkpuan.ToString();
            }
            else if (Convert.ToInt32(label21.Text) == Convert.ToInt32(label22.Text))
            {
                bjkpuan = bjkpuan + 1;
                label11.Text = bjkpuan.ToString();
            }



            if (Convert.ToInt32(label18.Text) > Convert.ToInt32(label15.Text))
            {
                fbpuan = fbpuan + 3;
                label12.Text = fbpuan.ToString();
            }

            else if (Convert.ToInt32(label18.Text) == Convert.ToInt32(label15.Text))
            {
                fbpuan = fbpuan + 1;
                label12.Text = fbpuan.ToString();
            }



            if (Convert.ToInt32(label18.Text) < Convert.ToInt32(label15.Text))
            {
                tspuan = tspuan + 3;
                label14.Text = tspuan.ToString();
            }
            else if (Convert.ToInt32(label18.Text) == Convert.ToInt32(label15.Text))
            {
                tspuan = tspuan + 1;
                label14.Text = tspuan.ToString();
            }
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            h = h + 1;
            textBox1.Text = h.ToString();
            if (h > 1)
            {
                button3.Enabled = false;
            }
            int a = rnd.Next(0, 5);
            int b = rnd.Next(0, 5);
            int c = rnd.Next(0, 4);
            int d = rnd.Next(0, 4);
            label32.Text = a.ToString();
            label33.Text = b.ToString();
            label31.Text = c.ToString();
            label30.Text = d.ToString();

            if (Convert.ToInt32(label32.Text) > Convert.ToInt32(label33.Text))
            {
                fbpuan = fbpuan + 3;
                label12.Text = fbpuan.ToString();
            }
            else if (Convert.ToInt32(label32.Text) == Convert.ToInt32(label33.Text))
            {
                fbpuan = fbpuan + 1;
                label12.Text = fbpuan.ToString();
            }



            if (Convert.ToInt32(label32.Text) < Convert.ToInt32(label33.Text))
            {
                bjkpuan = bjkpuan + 3;
                label11.Text = bjkpuan.ToString();
            }
            else if (Convert.ToInt32(label32.Text) == Convert.ToInt32(label33.Text))
            {
                bjkpuan = bjkpuan + 1;
                label11.Text = bjkpuan.ToString();
            }


            //

            if (Convert.ToInt32(label31.Text) > Convert.ToInt32(label30.Text))
            {
                tspuan = tspuan + 3;
                label14.Text = tspuan.ToString();
            }
            else if (Convert.ToInt32(label32.Text) == Convert.ToInt32(label33.Text))
            {
                tspuan = tspuan + 1;
                label14.Text = tspuan.ToString();
            }



            if (Convert.ToInt32(label31.Text) < Convert.ToInt32(label30.Text))
            {
                gspuan = gspuan + 3;
                label13.Text = bjkpuan.ToString();
            }
            else if (Convert.ToInt32(label31.Text) == Convert.ToInt32(label30.Text))
            {
                gspuan = gspuan + 1;
                label13.Text = bjkpuan.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(label13.Text) > Convert.ToInt32(label14.Text) && Convert.ToInt32(label13.Text) > Convert.ToInt32(label12.Text) && Convert.ToInt32(label13.Text) > Convert.ToInt32(label11.Text))
            {
                axWindowsMediaPlayer1.URL = @"C:\Users\Lenovo\OneDrive\Masaüstü\gs.mp3";
                label40.Text = "Sampiyon galatasaray!!!!!!!";
                pictureBox1.ImageLocation = @"C:\Users\Lenovo\OneDrive\Masaüstü\gs.png";
            }
            if (Convert.ToInt32(label14.Text) > Convert.ToInt32(label13.Text) && Convert.ToInt32(label14.Text) > Convert.ToInt32(label12.Text) && Convert.ToInt32(label14.Text) > Convert.ToInt32(label11.Text))
            {
                axWindowsMediaPlayer1.URL = @"C:\Users\Lenovo\OneDrive\Masaüstü\ts.mp3";
                label40.Text = "Sampiyon trabzonspor!!!!!!!";
                pictureBox1.ImageLocation = @"C:\Users\Lenovo\OneDrive\Masaüstü\ts.png";
            }
            if (Convert.ToInt32(label12.Text) > Convert.ToInt32(label13.Text) && Convert.ToInt32(label12.Text) > Convert.ToInt32(label14.Text) && Convert.ToInt32(label12.Text) > Convert.ToInt32(label11.Text))
            {
                axWindowsMediaPlayer1.URL = @"C:\Users\Lenovo\OneDrive\Masaüstü\fb.mp3";
                label40.Text = "Sampiyon fenerbahce!!!!!!!";
                pictureBox1.ImageLocation = @"C:\Users\Lenovo\OneDrive\Masaüstü\fb.png";
            }
             if (Convert.ToInt32(label11.Text) > Convert.ToInt32(label13.Text) && Convert.ToInt32(label11.Text) > Convert.ToInt32(label12.Text) && Convert.ToInt32(label11.Text) > Convert.ToInt32(label14.Text))
            {
                axWindowsMediaPlayer1.URL = @"C:\Users\Lenovo\OneDrive\Masaüstü\bjk.mp3";
                label40.Text = "Sampiyon besiktas!!!!!!!";
                pictureBox1.ImageLocation = @"C:\Users\Lenovo\OneDrive\Masaüstü\bjk.png";
            }
        }
    }
}
