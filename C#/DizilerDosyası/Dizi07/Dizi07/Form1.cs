using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dizi07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        string[] isim = new string[10];
        string[] ilce = new string[10];
        string[] telefon = new string[10];
        private void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            isim[i] = textBox1.Text;
            ilce[i] = textBox2.Text;
            telefon[i] = textBox3.Text;
            i++;
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i--;
            listBox1.Items.Add(isim[i]);
            listBox1.Items.Add(ilce[i]);
            listBox1.Items.Add(telefon[i]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i++;
            listBox1.Items.Add(isim[i]);
            listBox1.Items.Add(ilce[i]);
            listBox1.Items.Add(telefon[i]);
        }
    }
}
