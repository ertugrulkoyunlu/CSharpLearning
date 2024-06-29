using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Otomobil oto = new Otomobil();
            oto.marka = "Hyundai";
            oto.model = "assent";
            oto.modelyili = 2015;
            oto.renk = "mavi";
            oto.vitestipi = "otomatik";

            string marka = oto.markagetir();
            label6.Text = oto.marka;
            label7.Text = oto.model;
            label8.Text = oto.modelyili.ToString();
            label9.Text = oto.renk;
            label10.Text = oto.vitestipi;
        }
    }
}
