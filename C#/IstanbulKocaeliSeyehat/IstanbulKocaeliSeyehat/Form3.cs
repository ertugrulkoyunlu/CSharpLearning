using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IstanbulKocaeliSeyehat
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL= "http://37.247.98.8/stream/166/";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            webBrowser1.Navigate( "https://www.mgm.gov.tr/tahmin/il-ve-ilceler.aspx?il=ADANA");
        }
    }
}
