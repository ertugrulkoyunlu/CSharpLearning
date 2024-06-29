using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarOyunuNew
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int toplam = 0;
        int toplam2 = 0;
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int a = rnd.Next(1, 5);
            int b = rnd.Next(1, 5);
            int c = rnd.Next(1, 5);
            int d = rnd.Next(1, 5);
            int sonuc1;
            int sonuc2;
            
            sonuc1 = a + b;
            sonuc2 = c + d;
            label10.Text= Convert.ToString(sonuc1);
            label11.Text = Convert.ToString(sonuc2);
            toplam = toplam + a + b;
            toplam2 = toplam2 + c + d;
            
             label4.Text = a.ToString();
            label5.Text = b.ToString();
            label6.Text = c.ToString();
            label2.Text = d.ToString();
            if (sonuc1 > sonuc2)
            {
                label13.Text = "birinci oyuncu kazandi";
            }
            else
            {
                label13.Text = "ikinci oyuncu kazandi";
            }
            if (sonuc1 == sonuc2)
            {
                label13.Text = "berabere";
            }
            
           
            if (toplam > toplam2)
            {
                label17.Text = "birinci oyuncu kazandi";
            }
            else
            {
                label17.Text = "ikinci oyuncu kazandi";
            }
            if (toplam == toplam2)
            {
                label17.Text = "berabere";
            }
            label14.Text = toplam.ToString();
            label15.Text = toplam2.ToString();

           

        }
    }
}
