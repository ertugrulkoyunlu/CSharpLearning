using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PazarGununeKadar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime bugun = Convert.ToDateTime(textBox1.Text);
            DayOfWeek pazar = DayOfWeek.Sunday;
            int sayac = 0;
            while (bugun.DayOfWeek > pazar)
            {
                bugun = bugun.AddDays(1);
                sayac++;
            }
            listBox1.Items.Add(sayac.ToString());
            label1.Text = sayac.ToString();

        }
    }
}
