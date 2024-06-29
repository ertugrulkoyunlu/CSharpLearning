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
namespace Database15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source =C:\\Users\\Lenovo\\ZZDatabase\\basari1.accdb");
        //Data table sinifindan tablo1 adinda nesne olusturma
        DataTable Tablo1 = new DataTable();
        //OleDbDataAdapter sinifi veritabbaninda bulunan tablolardaki bilgilere ve sorgulamalara ulasma ve kullanma izni verir.

        OleDbDataAdapter adtr = new OleDbDataAdapter();
        //OleDbDataAdapter sinifinda adtr adinda bir nesne olusturma
        OleDbCommand cmd = new OleDbCommand();

        OleDbConnection conn2 = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source =C:\\Users\\Lenovo\\ZZDatabase\\basari2.accdb");
        DataTable Tablo2 = new DataTable();
        OleDbDataAdapter adtr2 = new OleDbDataAdapter();
        OleDbCommand cmd2 = new OleDbCommand();

        void listele()
        {
            Tablo1.Clear();
            conn.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from Tablo1 ", conn);
            adtr.Fill(Tablo1);
            dataGridView1.DataSource = Tablo1;
            adtr.Dispose();
            conn.Close();
        }
        void listele2()
        {
            Tablo2.Clear();
            conn.Open();
            OleDbDataAdapter adtr2 = new OleDbDataAdapter("Select * from Tablo2", conn2);
            adtr2.Fill(Tablo2);
            dataGridView2.DataSource = Tablo2;
            adtr.Dispose();
            conn2.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
            dataGridView1.Columns[0].HeaderText = "adi";
            dataGridView1.Columns[1].HeaderText = "soyadi";
            dataGridView1.Columns[2].HeaderText = "numarasi";
            dataGridView1.Columns[3].HeaderText = "vize1";
            dataGridView1.Columns[4].HeaderText = "vize2";
            dataGridView1.Columns[5].HeaderText = "final";

            listele2();
            dataGridView2.Columns[0].HeaderText = "adi";
            dataGridView2.Columns[1].HeaderText = "soyadi";
            dataGridView2.Columns[2].HeaderText = "numarasi";
            dataGridView2.Columns[3].HeaderText = "vize1";
            dataGridView2.Columns[4].HeaderText = "vize2";
            dataGridView2.Columns[5].HeaderText = "final";
            dataGridView2.Columns[6].HeaderText = "basari"; 




        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
