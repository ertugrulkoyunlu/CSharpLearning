using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int toplam= 0;
        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=0;i <6;i++)
            {
                toplam= toplam + i;
                label1.Text = toplam.ToString();
                listBox1.Items.Add(i);
                listBox2.Items.Add(toplam);
                
            }
            
        }
    }
}
