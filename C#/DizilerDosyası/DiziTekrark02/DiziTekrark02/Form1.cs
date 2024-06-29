using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiziTekrark02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int topla = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                
                topla+= sayilar[i];
                label1.Text = topla.ToString();
            }

        }
    }
}
