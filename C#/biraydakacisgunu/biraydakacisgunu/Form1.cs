using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biraydakacisgunu
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
            DateTime gun= new DateTime(bugun.Year,bugun.Month,1);
            MessageBox.Show(bugun.ToString());
            int sayac = 0;
            int isgunleri=0;
            int buay = DateTime.DaysInMonth(bugun.Year, bugun.Month);
            //MessageBox.Show(buay.ToString());
            while (sayac < buay)
            {
                if (!(gun.DayOfWeek == DayOfWeek.Sunday || gun.DayOfWeek == DayOfWeek.Saturday))
                {
                    isgunleri++;
                }
                sayac++;
                gun = gun.AddDays(1);
            }
            label1.Text = isgunleri.ToString();
        }
    }
}
