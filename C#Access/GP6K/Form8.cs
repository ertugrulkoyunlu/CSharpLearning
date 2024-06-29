using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GP6K
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }


        private void aboneBilgiGirisiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm = new Form2();
            frm.ShowDialog();

        }

        private void kayitAramaSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm = new Form3();
            frm.ShowDialog();
        }

        private void kayitDegistToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            this.Hide();
            Form4 frm = new Form4();
            frm.ShowDialog();
        }

        private void takvimToolStripMenuItem_Click(object sender, EventArgs e)
        {       
            this.Hide();
            Form5 frm = new Form5();
            frm.ShowDialog();
        }

        private void dogalgazHesapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void harcamaMiktariToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
