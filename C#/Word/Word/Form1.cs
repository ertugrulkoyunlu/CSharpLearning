using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wordeaktar =Microsoft.Office.Interop.Word;
using System.Reflection;
namespace Word
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wordeaktar.Application wordapp = new wordeaktar.Application();
            wordapp.Visible = true;
            wordeaktar.Document worddoc;
            object wordobj = System.Reflection.Missing.Value;
            worddoc= wordapp.Documents.Add(ref wordobj);
            wordapp.Selection.TypeText(richTextBox1.Text);
            } 
    }
}
