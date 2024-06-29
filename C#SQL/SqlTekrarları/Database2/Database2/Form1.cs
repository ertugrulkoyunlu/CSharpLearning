using System;
using System.Windows.Forms;
//Veri tabanlarina erismek icin  tanimlanmis sistem kutuphanesi
using System.Data.OleDb;

namespace Database2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Veri tabani cinsi surumu dosya yolu ve adinin belirlenmesi
            string source= "Provider=Microsoft.Ace.OleDb.12.0;Data Source=C://Users//Lenovo//ZZDatabase//dosya.accdb";
            
            //Veri tabani nesensinin yaratilmasi (OleDbConnection sinifindan Database baglanti kaynak nesenesinin yaratilmasi)
            OleDbConnection conn=new OleDbConnection(source);

            //Veri tabani kaynaginin acilmasi
            conn.Open();
            
            //Veri tabani kayit alanlarina ekrandan okunan bilgilerin aktarilmasi
            string query="Insert Into Tablo1 ([adi],[soyadi],[numarasi],[burutmaas],[kesinti],[netmaas])Values('" +
            textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text+ "','" +textBox5.Text + "','"+textBox6.Text +"')";
            
            //baglanti nesnesi ve sorgu stringi kullanilarak komut nesnesinin yaratilmasi
            OleDbCommand cmd = new OleDbCommand(query,conn);
            
            //komut nesenin  isletilmesi ve veritabanina yazilmasi
            MessageBox.Show(cmd.ExecuteNonQuery()+"Kayit eklendi");

        }
    }
}