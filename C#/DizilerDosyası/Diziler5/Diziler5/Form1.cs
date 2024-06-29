using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double [] sayilar ={1.24 , 5.84 , 8.75 , 2 ,4.14};
            int eleman = sayilar.Length;
            double topla= 0;
            for(int i =0 ; i< sayilar.Length;i ++)
            {
                topla= topla + sayilar[i];
                label2.Text = topla.ToString();
            }
            label1.Text = eleman.ToString();
            
        }
    }
}
