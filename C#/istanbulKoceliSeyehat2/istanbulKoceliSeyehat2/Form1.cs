using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace istanbulKoceliSeyehat2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adi = textBox1.Text;
            string soyadi = textBox2.Text;
            textBox1.Text = adi;
            listBox1.Items.Add(adi);
            textBox2.Text = soyadi;
            listBox2.Items.Add(soyadi);
            listBox3.Items.Add(comboBox1.Text);    
            if (radioButton1.Checked ==true)
            {
                listBox4.Items.Add(radioButton1.Text);
            }
            if(radioButton2.Checked ==true)
            {
                listBox4.Items.Add(radioButton2.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
