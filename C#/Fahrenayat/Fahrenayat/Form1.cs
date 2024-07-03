using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahrenayat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double derece=Convert.ToDouble(textBox1.Text);
            double fahrenayt=(derece*1.8)+32;
            textBox2.Text= fahrenayt.ToString();    
        }
    }
}
