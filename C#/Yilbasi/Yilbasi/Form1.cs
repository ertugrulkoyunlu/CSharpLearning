using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yilbasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Now;
            DateTime yilbasi = Convert.ToDateTime(01 + "/" + 01 + "/" + (bugun.Year + 1));
            TimeSpan fark = yilbasi.Subtract(bugun);
            yilbasi = Convert.ToDateTime(01 + "/" + 01 + "/" + bugun.Year);
            TimeSpan fark2 = bugun.Subtract(yilbasi);
            label1.Text = fark.Days.ToString();
            label2.Text = fark2.Days.ToString();
        }
    }
}
