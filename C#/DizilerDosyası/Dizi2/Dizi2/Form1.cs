using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dizi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isim = new string[10];
        string[] ilce = new string[10];
        string[] telefon = new string[10];
        int i = 0;
        void temizle()
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
            listBox1.Items.Add(textBox1.Text.ToString());
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
            temizle();  
        }
    }
}
