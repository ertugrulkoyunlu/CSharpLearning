using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dizelier4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int [] sayilar={5,6,7};
            int toplam = 0;
            for  (int i = 0; i<sayilar.Length; i++) 
            {
            toplam = toplam + sayilar[i];
            label1.Text = toplam.ToString();
            }

        }
    }
}
