using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP4CokBicimlilik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sepet spt = new sepet();
            ekmek ekm = new ekmek("Uno",1,"Kepekli",100);
            spt.Urunekle(ekm);
            MessageBox.Show(spt.toplamtutar().ToString());
        }
    }
}
