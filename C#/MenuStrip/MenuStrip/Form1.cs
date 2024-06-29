using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void esaretinBedeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "elma armut kel mahmut hasan hariye husnu  kasrikci";
            listBox1.Items.Add("Esaretin bedeli");
            listBox2.Items.Add(toolStripComboBox1.Text);

        }

        private void ameliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Amelia");
            richTextBox1.Text = "elma armut kel mahmut hasan hariye husnu  kasrikci";
            listBox2.Items.Add(toolStripComboBox1.Text);
            }

        private void gladyatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("gladyator");
            richTextBox1.Text = "elma armut kel mahmut hasan hariye husnu  kasrikci  kostekci fisdekci hanci  dasdada dasd asdadadadasdsada asdad adsa a d asd adadadasdsadasdasdsa ad sadadadada  adsasd";
            listBox2.Items.Add(toolStripComboBox1.Text);
        }

        private void felektenBirGeceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(toolStripComboBox1.Text);
            listBox1.Items.Add("felektenBirGece");
            richTextBox1.Text = "elma armut kel mahmut hasan hariye husnu  kasrikci  kostekci fisdekci hanci  dasdada dasd asdadadadasdsada asdad adsa a d asd adadadasdsadasdasdsa ad sadadadada  adsasd";
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {

            richTextBox1.Text = " ";
            
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
