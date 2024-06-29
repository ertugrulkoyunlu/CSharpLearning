using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmProgrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Hour.ToString();
            label2.Text = DateTime.Now.Minute.ToString();
            label3.Text = DateTime.Now.Second.ToString();
            if(comboBox2.Text==label2.Text && comboBox1.Text== label1.Text)
            {
                timer1.Enabled = false;
                axWindowsMediaPlayer1.URL=@"C:\Users\Lenovo\OneDrive\Masaüstü\mp3.mp3"; 
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             for(int i = 1;i<=24;i++)
             {
                comboBox1.Items.Add(i.ToString());
             }
             for(int j =1;j<=60;j++)
             {
                comboBox2.Items.Add(j.ToString());
             }
        }
    }
}
