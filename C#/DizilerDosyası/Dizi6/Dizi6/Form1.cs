using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dizi6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int [] sayilar ={1,2,3,4,5,6,7,8,9,10};
            int toplam = 0;
            foreach(int sayi in sayilar)
            {
              toplam = toplam + sayi;
              label1.Text= toplam.ToString();
            }
        }
    }
}
