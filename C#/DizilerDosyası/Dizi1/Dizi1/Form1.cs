using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dizi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = {0,15, 20, 21, 23, -30, -12, -15 };
            int toplam = 0;


            foreach (int sayi in sayilar)
            {
                if(sayi %5==0 && sayi>=0)
                {
                    listBox1.Items.Add(sayi);
                }
            }
        }
    }
}
