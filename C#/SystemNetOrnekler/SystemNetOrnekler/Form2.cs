using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
namespace SystemNetOrnekler
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                IPHostEntry siteadi = Dns.GetHostEntry(textBox1.Text);
                IPAddress[] ip = siteadi.AddressList;
                textBox2.Text = ip[0].ToString();
                ListViewItem add = new ListViewItem();
                add.Text = textBox1.Text.ToString();
                add.SubItems.Add( textBox2.Text.ToString());
                listView1.Items.Add(add);
            }
            catch (Exception)
            {

                MessageBox.Show("Yokk");
            }
        }
    }
}
