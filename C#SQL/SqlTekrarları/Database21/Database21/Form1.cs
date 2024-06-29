using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abonebilgigirisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void kayitaramasilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm = new Form3();
            frm.ShowDialog();
        }

        private void kayitdegistirmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 frm = new Form4();
            frm.ShowDialog();
        }
    }
}
