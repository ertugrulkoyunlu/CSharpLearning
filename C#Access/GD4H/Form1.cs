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


namespace GD4H
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //1.veri tabanı database
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Lenovo\\ZDatabases\\basari1.accdb");
        //Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Lenovo\\ZDatabases\\basari1.accdb
        DataTable Tablo1 = new DataTable();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        OleDbCommand kmt = new OleDbCommand();


        //2.veri tabanı database    
        OleDbConnection bag2 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Lenovo\\ZDatabases\\basari2.accdb");
        DataTable Tablo2 = new DataTable();
        OleDbDataAdapter adtr2 = new OleDbDataAdapter();
        OleDbCommand kmt2 = new OleDbCommand();

        void ListeleA()
        {
            Tablo1.Clear();//temizle
            bag.Open();

            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From Tablo1", bag);
            adtr.Fill(Tablo1);
            dataGridView1.DataSource = Tablo1;
            adtr.Dispose();
            bag.Close();
        }


        void ListeleB()
        {
            Tablo2.Clear();// tabloda fazladan veri kalmasını engelleyen komut Tüm tabloyu siler
            bag2.Open(); //bağlantıyı yani kaynak dosyasını açar

            OleDbDataAdapter adtr2 = new OleDbDataAdapter("Select * From Tablo2", bag2);
            adtr2.Fill(Tablo2);                                             //Alınan verileri Tablo2 ye doldurur.
            dataGridView2.DataSource = Tablo2;                              //Tablo2 ye geçen verileri "dataGridView2.DataSource" formunda gösterir
            adtr2.Dispose();                                                //Acılan verileri tamamen siler
            bag2.Close();                                                   // kaynak dosyasını kapatır.
            /*OleDbDataAdapter adtr2 = new OleDbDataAdapter("Select *From Tablo2", bag2);*/
            /*==00*//*= 
            DataAdapter veri almak ve kaydetmek için bir DataSet ile veri kaynağı arasında bir köprü görevi görür.*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListeleA();
            dataGridView1.Columns[1].HeaderText = "Ad";      // burda hata var ise eğer  edit ile teker teker çıkar bazen sadece bir tane şey sütünda bütün sütün
            dataGridView1.Columns[2].HeaderText = "Soyad";   // birleşebiliyor.
            dataGridView1.Columns[3].HeaderText = "Numara";
            dataGridView1.Columns[4].HeaderText = "VizeI";
            dataGridView1.Columns[5].HeaderText = "VizeII";
            dataGridView1.Columns[6].HeaderText = "Final";
            ListeleB();
            dataGridView2.Columns[7].HeaderText = "Ad";      // eğer aynı yazı 2 kere gözüküyorsa sütünları azaltınca düzeliyor.Sütünları fazla koymuş olabilir yada
            dataGridView2.Columns[8].HeaderText = "Soyad";   // yukardaki gibi birleşme oluyor olabilir.
            dataGridView2.Columns[9].HeaderText = "Numara";
            dataGridView2.Columns[10].HeaderText = "Vize1";
            dataGridView2.Columns[11].HeaderText = "Vize2";
            dataGridView2.Columns[12].HeaderText = "Vizeort";
            dataGridView2.Columns[13].HeaderText = "Final";


        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Insert Into Tablo1(ad,soyad,numara,vizeI,vizeII,final)VALUES('" + ad.Text + "','" + soyad.Text + "','" +
            numara.Text + "','" + vize1.Text + "','" + vize2.Text + "','" + final.Text + "')";
            kmt.ExecuteNonQuery();
            kmt.Dispose();
            bag.Close();
            ListeleA();
            ad.Clear();
            soyad.Clear();
            numara.Clear();
            vize1.Clear();
            vize2.Clear();
            final.Clear();
        }

        private void ngs_Click(object sender, EventArgs e)
        {
            kmt.Connection = bag;
            bag.Open();

            kmt.CommandText = "delete from Tablo1 where numara= '" + numara.Text + "'";
            MessageBox.Show(kmt.CommandText);
            kmt.ExecuteNonQuery();
            bag.Close();
            ListeleA();
        }

        private void adkb_Click(object sender, EventArgs e)
        {
            bag.Open();
            DataTable dt = new DataTable();
            OleDbDataAdapter adi = new OleDbDataAdapter("select * From Tablo1 Where ad='" + ad.Text + "'", bag);
            adi.Fill(dt);
            dataGridView1.DataSource = dt;
            bag.Close();

        }

        private void tl_Click(object sender, EventArgs e)
        {
            ListeleA();
        }

        private void kydgs_Click(object sender, EventArgs e)
        {
            bag.Open();
            DataTable dt = new DataTable();
            OleDbDataAdapter adi = new OleDbDataAdapter("UPDATE Tablo1 SET ad= '" + ad.Text + "'WHERE numara='" + numara.Text + "'", bag);
            adi.Fill(dt);
            dataGridView1.DataSource = dt;
            bag.Close();
            ListeleA();
        }

        private void benzerad_TextChanged(object sender, EventArgs e)
        {
            bag.Open();
            DataTable dt = new DataTable();
            OleDbDataAdapter adi = new OleDbDataAdapter("Select * From Tablo1 WHERE ad LIKE '%" + benzerad.Text + "%'", bag);
            adi.Fill(dt);
            dataGridView1.DataSource = dt;
            bag.Close();

        }

        private void vtyaz_Click(object sender, EventArgs e)
        {
            OleDbConnection baglan = new OleDbConnection();
            OleDbCommand sec = new OleDbCommand();
            OleDbCommand ekle = new OleDbCommand();
            OleDbDataReader oku;
            double vizeort, basari;
            string vizeo, basar;


            baglan.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Lenovo\\ZDatabases\\basari1.accdb";

            baglan.Open();
            sec = baglan.CreateCommand();
            sec.CommandText = "Select * From Tablo1";
            oku = sec.ExecuteReader();


            while (oku.Read())
            {
                ad.Text = "" + oku["ad"];
                soyad.Text = "" + oku["soyad"];
                numara.Text = "" + oku["numara"];
                vize1.Text = "" + oku["vizeI"];
                vize2.Text = "" + oku["vizeII"];


                vizeort = (Convert.ToDouble(vize1.Text) + Convert.ToDouble(vize2.Text)) / 2;
                vizeo = Convert.ToString(vizeort);

                final.Text = "" + oku["final"];

                basari = vizeort * 0.4 + (Convert.ToDouble(final.Text)) * 0.6;
                basar = Convert.ToString(basari);



                string kaynak = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Lenovo\\ZDatabases\\basari2.accdb";
                //"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Lenovo\\ZDatabases\\basari1.accdb"
                OleDbConnection baglanti = new OleDbConnection(kaynak);
                baglanti.Open();

                string sorgu = "INSERT INTO Tablo2([ad],[soyad],[numara],[vize1],[vize2],[vizeort],[final],[basari])Values('" + ad.Text + "','" + soyad.Text +
                "','" + numara.Text + "','" + vize1.Text + "','" + vize2.Text + "','" + vizeo + "','" + final.Text + "','" + basar + "' )";


                OleDbCommand komut = new OleDbCommand(sorgu, baglanti);
                MessageBox.Show(komut.ExecuteNonQuery() + "Kayit eklendi.");

                baglanti.Close();
                ListeleA();
                ListeleB();
                ad.Clear();
                soyad.Clear();
                numara.Clear();
                vize1.Clear();
                vize2.Clear();
                final.Clear();
                benzerad.Clear();
            }
        }

        private void ngs2_Click(object sender, EventArgs e)
        {

            kmt2.Connection = bag2;
            bag2.Open();
            kmt2.CommandText = "delete * from Tablo2  ";
            kmt2.ExecuteNonQuery();
            bag2.Close();
            ListeleB();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kmt.Connection = bag;
            bag.Open();
            kmt.CommandText = "delete * from Tablo1  ";
            kmt.ExecuteNonQuery();
            bag.Close();
            ListeleA();
        }
    }
}
