using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace MetinBelgesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StreamWriter sw;
        string belgea, belgey;

        private void button2_Click(object sender, EventArgs e)
        {
            belgea = textBox1.Text;
            sw = File.CreateText(belgey + "\\" + belgea + ".txt");
            sw.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader oku = new StreamReader(openFileDialog1.FileName);
                string satir = oku.ReadLine();
                while (satir != null)
                {
                    listBox1.Items.Add(satir);
                    satir = oku.ReadLine();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ac = new OpenFileDialog();
            ac.Filter = "Metin Dosyası(*.txt)|*txt";
            ac.Multiselect = false;
            if (ac.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox3.Text = ac.SafeFileName;
                try
                {
                    StreamReader read = new StreamReader(ac.FileName);
                    richTextBox1.Text = read.ReadToEnd();
                    read.Close();
                }
                catch
                {
                    MessageBox.Show("hata");
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Title = "Kayit yerini secin";
                saveFileDialog1.Filter ="Metin Dosyası(*.txt)|*txt";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.InitialDirectory ="C:\\";
                saveFileDialog1.ShowDialog();
                StreamWriter kaydet = new StreamWriter(saveFileDialog1.FileName);
                kaydet.WriteLine(richTextBox2.Text);
                kaydet.Close();
                MessageBox.Show("Kaynak metikn belgesine yazdirildi");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                belgey = folderBrowserDialog1.SelectedPath.ToString();
                textBox2.Text = belgey;
            }
        }
    }
}
