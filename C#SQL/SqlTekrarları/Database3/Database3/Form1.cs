using System;
using System.Windows.Forms;
// identfyied system library for acces the database.
using System.Data.OleDb;

namespace Database3
{
    public partial class Form1 : Form
    {
        public Form1 ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Database create type version file path
            string source="Provider=Microsoft.Ace.OleDb.12.0;Data Source=C:\\Users\\Lenovo\\ZZDatabase\\dosya.accdb";
            
            //Creation database object(create database  connection  source list in OleDbConnection class ) [veri tabani nesnesinin olustrulumasi(OleDbConnection sinifindan database baglanti kaynak nesnesinin yaratilmasi  )]            
            OleDbConnection conn = new OleDbConnection(source);

            //Opening the database source.(Veri tabani kaynaginin acilmasi)
            conn.Open();
           
            //Transferring information from screen to database registration areas(veri tabani kayit alanlarina ekrandan okunan bilgilerin aktarilmasi)
            string query= "Insert Into Tablo1 ([adi],[soyadi],[numarasi],[burutmaas],[kesinti],[netmaas])Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text +
            "','" + textBox4.Text + "','" +textBox5.Text + "','" + textBox6.Text +"')";
            
            //Creating command object using connection class and query string(Baglanti nesnesi ve sorgu dizesi(string) kullanilarak komut nesnesinin yaratilmasi)
            OleDbCommand cmd = new OleDbCommand(query,conn);
            
            //(Operating command class and writing in database)Komut nesnesinin isletilmesi ve veri tabanina yazilmasi
            MessageBox.Show( cmd.ExecuteNonQuery() + "kayit eklendi");

            //Closing the database source(Veri tabani kaynaginin kapatilmasi)
            conn.Close();
        }
    }


}