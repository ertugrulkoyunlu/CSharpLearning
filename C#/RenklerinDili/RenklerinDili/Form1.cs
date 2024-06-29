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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "a" && textBox2.Text == "1")
            {
                Form2 frm = new Form2();
                frm.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatali giris yaptiniz.");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm = new Form2();
            frm.ShowDialog();

        }
    }
}
