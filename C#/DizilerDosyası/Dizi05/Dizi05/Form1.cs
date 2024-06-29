using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dizi05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int toplam=0;
        int toplama=0;
        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 11, 12, 25, 36, 48, 46, 154 };
            foreach (int sayi in sayilar)
            {
                if (sayi % 2 == 0)
                {
                    toplam+= sayi;
                    listBox1.Items.Add(sayi);
                    label1.Text = toplam.ToString();
                }
                if (sayi % 2 == 1)
                {
                    toplama+=sayi;
                    listBox2.Items.Add(sayi);
                    label2.Text = toplama.ToString();
                }
            }
        }
    }
}
