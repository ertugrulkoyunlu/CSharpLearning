using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaktoriyelOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         int faktoriyel=1;
        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <6 ; i++) 
            {
                faktoriyel = faktoriyel*i;
                label1.Text = faktoriyel.ToString();
                listBox1.Items.Add(i);  
                listBox2.Items.Add(faktoriyel);
            }
        }
    }
}
