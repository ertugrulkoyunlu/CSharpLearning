using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
             axWindowsMediaPlayer1.URL= @"C:\Users\Lenovo\OneDrive\Masaüstü\mp3.mp3";
             pictureBox1.ImageLocation= @"C:\Users\Lenovo\OneDrive\Masaüstü\img28.jpg";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL= @"C:\Users\Lenovo\OneDrive\Masaüstü\A.mp3";
            pictureBox1.ImageLocation= @"C:\Users\Lenovo\OneDrive\Masaüstü\A.png";
        }
    }
}
