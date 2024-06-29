using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Insan ins = new Insan();
            ins.ad = "murat";
            ins.soyad = "yucedag";
            ins.yas = 21;
            ins.kilo = 75;
            Personel pers = new Personel();
            pers.departman = "egitim";
            pers.boy = 180;
            pers.yer = "Sube-1";
            label1.Text = ins.ad.ToString();
            label2.Text = ins.soyad.ToString();
            label3.Text = ins.yas.ToString();
            label4.Text = ins.kilo.ToString();
            label5.Text = pers.departman.ToString();
            label6.Text = pers.boy.ToString();
            label7.Text = pers.yer.ToString();
            pers.boy = 180;
            pers.kilo= 90;
            label8.Text = pers.boy.ToString();
            label9.Text = pers.kilo.ToString();


        }
    }
}
