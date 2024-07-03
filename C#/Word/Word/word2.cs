using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using word = Microsoft.Office.Interop.Word;
using System.Reflection;
namespace Word
{
    public partial class word2 : Form
    {
        public word2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object omissing = System.Reflection.Missing.Value;
            object dokumansonu = "\\endofdoc";

            word.Application olustur;
            word.Document icerik;
            olustur = new word.Application();
            olustur.Visible = true;
            icerik = olustur.Documents.Add(ref omissing);
            
            word.Paragraph paragraf;
            paragraf = icerik.Content.Paragraphs.Add(ref omissing);
            paragraf.Range.Text = "1.Paragraf";
            paragraf.Range.Font.Bold = 1;
            paragraf.Format.SpaceAfter = 50;
            paragraf.Range.InsertParagraphAfter();
            
            word.Paragraph paragraf2;
            object hedef = icerik.Bookmarks.get_Item(ref dokumansonu).Range;
            paragraf2 = icerik.Content.Paragraphs.Add(ref hedef);
            paragraf2.Range.Text = "2.Paragraf";
            paragraf2.Format.SpaceAfter = 100;
            paragraf2.Range.InsertParagraphAfter();
        }
    }
}
