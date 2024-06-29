using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance__Kalıtım_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ikincisınıf sinifim =new ikincisınıf();
            sinifim.OzelMesajKutusu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ikincisınıf adGosterSinif = new ikincisınıf();
            adGosterSinif.AdGoster();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          üçüncü 
          
        }
    }
}