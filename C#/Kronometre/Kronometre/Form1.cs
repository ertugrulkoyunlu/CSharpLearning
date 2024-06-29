using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
            int dakika =0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            int sayi=Convert.ToInt32(label1.Text);
            
            sayi++;
            label1.Text = sayi.ToString(); 
            if(sayi==61)
            {
             sayi=0;
             label1.Text =sayi.ToString();
             dakika++;
             label2.Text = dakika.ToString();
            }
        }
    }
}
