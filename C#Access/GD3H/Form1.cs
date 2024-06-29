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
namespace GD3H
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Birinci veritabanı ve Tablo1 İçin tanımlamalar
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\\Users\\Lenovo\\ZDatabases\\basari1.accdb");
        DataTable Tablo1 = new DataTable();// DataTable sınıfından Tablo1 adında nesne oluşturma
        OleDbDataAdapter adtr = new OleDbDataAdapter();// OleDbDataAdapter sınıfı veritabanında bulunan tablolardaki bilgilere ve sorgulamalara ulaşma ve kullanma izni verir
                                                       // OleDbDataAdapter sınıfından adtr adında bir nesne oluşturma
        OleDbCommand kmt = new OleDbCommand();


        // İkinci veritabanı ve Tablo2 İçin tanımlamalar
        OleDbConnection bag2 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Lenovo\\ZDatabases\\basari2.accdb");
        DataTable Tablo2 = new DataTable();// DataTable sınıfından Tablo2 adında nesne oluşturma
        OleDbDataAdapter adtr2 = new OleDbDataAdapter();// OleDbDataAdapter sınıfı veritabanında bulunan tablolardaki bilgilere ve sorgulamalara ulaşma ve kullanma izni verir
                                                        // OleDbDataAdapter sınıfından adtr adında bir nesne oluşturma
        OleDbCommand kmt2 = new OleDbCommand();


        //Listele alt programının tanımlanması
        void Listele()
        {
            Tablo1.Clear();
            bag.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from Tablo1", bag);
            adtr.Fill(Tablo1);
            dataGridView1.DataSource = Tablo1;
            adtr.Dispose();
            bag.Close();
        }
        void Listele2()
        {
            Tablo2.Clear();
            bag2.Open();
            OleDbDataAdapter adtr2 = new OleDbDataAdapter("select * from Tablo2", bag2);
            adtr2.Fill(Tablo2);
            dataGridView2.DataSource = Tablo2;
            adtr2.Dispose();
            bag2.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
            dataGridView1.Columns[1].HeaderText = "Adi";
            dataGridView1.Columns[2].HeaderText = "Soyadi";
            dataGridView1.Columns[3].HeaderText = "Numarasi";
            dataGridView1.Columns[4].HeaderText = "VizeI";
            dataGridView1.Columns[5].HeaderText = "VizeII";
            dataGridView1.Columns[6].HeaderText = "Final";


            Listele2();
            dataGridView2.Columns[7].HeaderText = "Adi";
            dataGridView2.Columns[8].HeaderText = "Soyadi";
            dataGridView2.Columns[9].HeaderText = "Numarasi";
            dataGridView2.Columns[10].HeaderText = "Vize1";
            dataGridView2.Columns[11].HeaderText = "Vize2";
            dataGridView2.Columns[12].HeaderText = "Vizeort";
            dataGridView2.Columns[13].HeaderText = "Final";
            dataGridView2.Columns[14].HeaderText = "Basari";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
