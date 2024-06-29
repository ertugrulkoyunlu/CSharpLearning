using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP3Kapsulleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            emlak evim = new emlak();
            evim.Semt = textBox1.Text;
            evim.Odasayisi = Convert.ToInt32(textBox2.Text);
            evim.Katno = Convert.ToInt32(textBox3.Text);
            evim.Alan = Convert.ToInt32(textBox4.Text);
            ListViewItem add = new ListViewItem();
            add.Text = evim.Semt;
            add.SubItems.Add(evim.Odasayisi.ToString());
            add.SubItems.Add(evim.Katno.ToString());
            add.SubItems.Add(evim.Alan.ToString());
                
            listView1.Items.Add(add);
        }
    }
}
