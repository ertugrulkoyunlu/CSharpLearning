using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        int birinciatsolauzaklik, ikinciatsolauzaklik, ucuncuatsolauzaklik;
        Random rastgele = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsolauzaklik = pictureBox1.Left;
            ikinciatsolauzaklik = pictureBox2.Left;
            ucuncuatsolauzaklik = pictureBox3.Left;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int derece = Convert.ToInt32(label7.Text);
            derece++;
            label7.Text = derece.ToString(); 




            int birinciatgenisligi = pictureBox1.Width;
            int ikinciatgenisligi = pictureBox2.Width;
            int ucuncuatgenisligi = pictureBox3.Width;
            int bitisuzakligi = label5.Left;

            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 15);

            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label6.Text = "Bir numarali at onde !!!!!";
            }

            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = "Iki numarali at onde !!!!!";
            }

            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5)
            {
                label6.Text = "Uc numarali at onde !!!!!";
            }


            if (birinciatgenisligi + pictureBox1.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                label6.Text = "bir numarali at kazandi";
            }

            if (ikinciatgenisligi + pictureBox2.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                label6.Text = "iki numarali at kazandi";
            }

            if (ucuncuatgenisligi + pictureBox3.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                label6.Text = "uc numarali at kazandi";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }


    }
}
