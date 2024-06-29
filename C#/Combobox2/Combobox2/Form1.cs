using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combobox2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox2.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "C# dersi basladi";
            label1.Text = "deneme merhaba dunya";
            comboBox1.Items.Add(textBox1.Text);
            comboBox1.Items.Add(label1.Text);
            comboBox1.Items.Add("Istanbul");
            listBox1.Items.Add(textBox1.Text);
            listBox1.Items.Add(label1.Text);
        }
    }
}
