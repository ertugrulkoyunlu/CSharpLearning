using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] gunler = new string[7];
            gunler[0] = "pazartesi";
            gunler[1] = "sali";
            gunler[2] = "carsamba";
            gunler[3] = "persembe";
            gunler[4] = "cuma";
            gunler[5] = "cumartesi";
            gunler[6] = "pazar";
            label1.Text = gunler[2];
            listBox1.Items.AddRange(gunler);
        }
    }
}
