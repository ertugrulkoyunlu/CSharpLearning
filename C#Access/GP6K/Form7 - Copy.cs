using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GP6K
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult onay=MessageBox.Show("Cikmak istediginize emin misiniz","Cikis islemi",MessageBoxButtons.YesNo);
            
            if(onay==DialogResult.Yes)  
            {
            this.Close();
            }
            else
            {
            
            }
        }
    }
}
