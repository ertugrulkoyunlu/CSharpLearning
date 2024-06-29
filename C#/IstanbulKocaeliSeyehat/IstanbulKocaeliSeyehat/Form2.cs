using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IstanbulKocaeliSeyehat
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox7.Items.Add("1");
            listBox2.Items.Add(textBox1.Text);
            listBox3.Items.Add(textBox2.Text);
            listBox4.Items.Add(comboBox1.Text);
            if (radioButton1.Checked == true)
            {
                listBox5.Items.Add(radioButton1.Text);

            }
            else if (radioButton2.Checked == true)
            {
                listBox5.Items.Add(radioButton2.Text);
            }
            textBox4.Clear();
            listBox6.Items.Add(comboBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            button2.Enabled = false;
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm = new Form3();
            frm.ShowDialog();

        }

        private void girisyapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox7.Items.Add("2");
            listBox2.Items.Add(textBox1.Text);
            listBox3.Items.Add(textBox2.Text);
            listBox4.Items.Add(comboBox1.Text);

            if (radioButton1.Checked == true)
            {
                listBox5.Items.Add(radioButton1.Text);
            }
            if (radioButton2.Checked == true)
            {
                listBox5.Items.Add(radioButton2.Text);
            }
            listBox6.Items.Add(comboBox2.Text);

            textBox4.Clear();
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            button3.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox7.Items.Add("3");
            listBox2.Items.Add(textBox1.Text);
            listBox3.Items.Add(textBox2.Text);
            listBox4.Items.Add(comboBox1.Text);

            if (radioButton1.Checked == true)
            {
                listBox5.Items.Add(radioButton1.Text);
            }
            if (radioButton2.Checked == true)
            {
                listBox5.Items.Add(radioButton2.Text);
            }
            listBox6.Items.Add(comboBox2.Text);

            textBox4.Clear();
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox7.Items.Add("4");
            listBox2.Items.Add(textBox1.Text);
            listBox3.Items.Add(textBox2.Text);
            listBox4.Items.Add(comboBox1.Text);

            if (radioButton1.Checked == true)
            {
                listBox5.Items.Add(radioButton1.Text);
            }
            if (radioButton2.Checked == true)
            {
                listBox5.Items.Add(radioButton2.Text);
            }
            listBox6.Items.Add(comboBox2.Text);

            textBox4.Clear();
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox7.Items.Add("5");
            listBox2.Items.Add(textBox1.Text);
            listBox3.Items.Add(textBox2.Text);
            listBox4.Items.Add(comboBox1.Text);

            if (radioButton1.Checked == true)
            {
                listBox5.Items.Add(radioButton1.Text);
            }
            if (radioButton2.Checked == true)
            {
                listBox5.Items.Add(radioButton2.Text);
            }
            listBox6.Items.Add(comboBox2.Text);

            textBox4.Clear();
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox7.Items.Add("6");
            listBox2.Items.Add(textBox1.Text);
            listBox3.Items.Add(textBox2.Text);
            listBox4.Items.Add(comboBox1.Text);

            if (radioButton1.Checked == true)
            {
                listBox5.Items.Add(radioButton1.Text);
            }
            if (radioButton2.Checked == true)
            {
                listBox5.Items.Add(radioButton2.Text);
            }
            listBox6.Items.Add(comboBox2.Text);

            textBox4.Clear();
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            button7.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox4.Text);
            if (radioButton4.Checked == true)
            {
                listBox1.Items.Add(radioButton4.Text);

            }
            else if (radioButton3.Checked == true)
            {
                listBox1.Items.Add(radioButton3.Text);
            }
        }
    }
}
