using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenklerinDili
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "mavi")
            {
                label3.Text = textBox1.Text + " " + comboBox1.Text + " rengi sever";
                button2.BackColor = Color.Blue;
            }

            if (comboBox1.Text == "sari")
            {
                label3.Text = textBox1.Text + " " + comboBox1.Text + " rengi sever";
                button2.BackColor = Color.Yellow;
            }

            if (comboBox1.Text == "kirmizi")
            {
                label3.Text = textBox1.Text + " " + comboBox1.Text + " rengi sever";
                button2.BackColor = Color.Red;
            }
            
           if (comboBox1.Text == "siyah")
            {
                label3.Text = textBox1.Text + " " + comboBox1.Text + " rengi sever";
                button2.BackColor = Color.Black;
            }

            if (comboBox1.Text == "beyaz")
            {
                label3.Text = textBox1.Text + " " + comboBox1.Text + " rengi sever";
                button2.BackColor = Color.White;
            }

            if (comboBox1.Text == "yesil")
            {
                label3.Text = textBox1.Text + " " + comboBox1.Text + " rengi sever";
                button2.BackColor = Color.Green;
            }
            
        }
    }
}

