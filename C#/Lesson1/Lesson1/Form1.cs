using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label2.Text = textBox2.Text;
            label6.Text = comboBox1.Text;
            label8.Text = textBox3.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Adana");
            comboBox1.Items.Add("Malatya");
            comboBox1.Items.Add("Kayseri");

        }
    }
}
