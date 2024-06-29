using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseClick
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }
        Click c = new Click();
        private void button1_Click(object sender, EventArgs e)
        {
            Point p = new Point();
            p.X = 100;
            p.Y = 100;
            c.leftClick(p);
        }
    }
}

