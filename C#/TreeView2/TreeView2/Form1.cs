using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                treeView1.Nodes.Add(i.ToString());
                for (int k = 0; k < 3; k++)
                {
                    treeView1.Nodes[i - 1].Nodes.Add(k.ToString());
                }
            }
            for (int j = 0; j < treeView1.Nodes.Count; j++)
            {
                listBox1.Items.Add(treeView1.Nodes[j].ToString());
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            label1.Text =e.Node.ToString();
        }
    }
}
