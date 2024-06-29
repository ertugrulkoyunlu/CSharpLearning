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

namespace GP6K
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //Birinci veri tabani ve Tablo1 icin tanimlamalar
        //Definitons for primary database and Table1
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Lenovo\\elektrik.accdb");
        DataTable Tablo1 = new DataTable();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        OleDbCommand cmd1 = new OleDbCommand();

        private void sv1_Click(object sender, EventArgs e)
        {
            int dogalgaz;
            dogalgaz = (Convert.ToInt32(textBox6.Text)) - (Convert.ToInt32(textBox5.Text));
            textBox8.Text = Convert.ToString(dogalgaz);
            conn.Open();

            cmd1.Connection = conn;
            cmd1.CommandText = "Insert Into Tablo1([Adi],[Soyadi],[Adresi],[sayacno],[ilkendex],[sonendex],[Aboneno],[dogalgaz]) Values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text +
            "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')";
            MessageBox.Show(cmd1.ExecuteNonQuery() + "Kayit eklendi.");
            cmd1.Dispose();
            conn.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {


            this.Hide();
            Form8 frm = new Form8();
            frm.ShowDialog();
        }
    }
}
