using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPTekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sepet spt = new Sepet();
            Ekmek ekm = new Ekmek("Uno", 1, "Kepekli", 100);
            spt.Urunekle(ekm);
            MessageBox.Show(spt.toplamtutar().ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sepet spt = new Sepet();
            CepTelefonu tlfn = new CepTelefonu("pro max", 1000, "iphone");
            spt.Urunekle(tlfn);
            MessageBox.Show(spt.toplamtutar().ToString());
        }
    }
}
