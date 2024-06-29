using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dizi7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int [] sayilar = {11,12,25,36,48,66,154,-25,-27,-39,-41};
            foreach(int sayi in sayilar)
            {
                if(sayi %3 ==0 &&  sayi<0)
                {
                    listBox1.Items.Add(sayi);
                }
                if(sayi %2 ==1)
                {
                    listBox2.Items.Add(sayi);
                }
            }
        }
    }
}
