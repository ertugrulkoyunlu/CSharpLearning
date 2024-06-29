using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aboneBilgiGirisiToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void kayitDegistirmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 frm = new Form4();
            frm.ShowDialog();
        }

        private void harcamaMiktariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 frm = new Form5();
            frm.ShowDialog();
        }

        private void listelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 frm = new Form6();
            frm.ShowDialog();
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
