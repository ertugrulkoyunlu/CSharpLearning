using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Kucuk");
            comboBox1.Items.Add("Orta");
            comboBox1.Items.Add("Buyuk");
            comboBox2.Items.Add("Kola");
            comboBox2.Items.Add("Ayran");
            comboBox2.Items.Add("Soda");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
            listBox4.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            listBox6.Items.Add(label13.Text + " " + label14.Text + " " + label15.Text);
            listBox6.Items.Add(label16.Text + " " + label17.Text + " " + label18.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                label13.Text = checkBox1.Text;
                
            }
            if (checkBox1.Checked == false)
            {
                
                label13.Text = "";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                label14.Text = checkBox2.Text;
                
            }
            if (checkBox2.Checked == false)
            {
                
                label14.Text = "";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                label15.Text = checkBox3.Text;
                
            }
            if (checkBox3.Checked == false)
            {
                
                label15.Text = "";
            }
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                label16.Text = checkBox4.Text;
                
            }
            if (checkBox4.Checked == false)
            {
                
                label16.Text = "";
            }
            
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                label17.Text = checkBox5.Text;
                
            }
            if (checkBox5.Checked == false)
            {
                
                label17.Text = "";
            }
            
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                label18.Text = checkBox6.Text;
                
            }
            if (checkBox6.Checked == false)
            {
                
                label18.Text = "";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            
        }
    }
}
