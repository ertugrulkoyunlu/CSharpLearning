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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Otomobil oto = new Otomobil();
            oto.marka = "Hyunduai";
            oto.model = "Gets";
            oto.modelyili = 2013;
            oto.renk = "beyaz";
            oto.vitestipi = "manuel";
            label6.Text = oto.marka;
            label7.Text = oto.model;
            label8.Text = oto.modelyili.ToString();
            label9.Text = oto.renk;
            label10.Text = oto.vitestipi;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm = new Form2();
            frm.ShowDialog();
        }
    }
}
