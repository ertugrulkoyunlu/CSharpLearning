using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            a = a + 1;
            label1.Text = a.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            a = a + 3;
            label2.Text = a.ToString();
        }
    }
}
