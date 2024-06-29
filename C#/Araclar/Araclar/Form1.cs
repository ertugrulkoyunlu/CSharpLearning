using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araclar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (vScrollBar1.Value <= 30 && vScrollBar1.Value >= 0)
            {
                this.BackColor = Color.Purple;
            }
            if (vScrollBar1.Value > 30 && vScrollBar1.Value<=50)
            {
                this.BackColor = Color.Pink;
            }
            if(vScrollBar1.Value >50 && vScrollBar1.Value <=75)
            {
                this.BackColor = Color.Orchid;
            }
            if(vScrollBar1.Value >75 && vScrollBar1.Value <100)
            {
                this.BackColor = Color.MediumSeaGreen;
            }
        }
    }
}
