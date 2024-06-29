using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Database22
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source= C:\\Users\\Lenovo\\ZZDatabase\\elektrik.accdb");
        DataTable Tablo1 = new DataTable();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        OleDbCommand cmd = new OleDbCommand();



        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText ="Insert Into Tablo1 (adi,soyadi,adresi,sayacno,ilkendex,sonendex,aboneno)Values('"+ textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text +
            "','" + textBox6.Text + "','" +textBox7.Text + "')";
            MessageBox.Show(cmd.ExecuteNonQuery()+"kayit eklendi");
            cmd.Dispose();
            conn.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();

        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.ShowDialog();
        }
    }
}
