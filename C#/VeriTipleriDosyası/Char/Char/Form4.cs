using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Char
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {   
            char karakter;
            char [] dizi = {'1','2','3','4','5'};
            int rakam = rnd.Next(0,dizi.Length);
            karakter =dizi[rakam];
            label1.Text = karakter.ToString();
        }
    }
}
