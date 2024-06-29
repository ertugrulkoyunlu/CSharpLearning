using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yordam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int sonuc;
            textBox1.Text = a.ToString();
            textBox2.Text = b.ToString();
            sonuc = a + b;
            textBox3.Text = sonuc.ToString(); 
        }
        private void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
