using System;
using System.Windows.Forms;

// Veri trabanlarina erismek icin kullanilan sistem kutuphanesi
using System.Data.OleDb;
        
namespace DataBase1
{
    public partial class Form1:Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            
        private void button1_Click(object sender, EventArgs e)
        {
           // Veri tabaninin surumunu cinsi  dosya yolu ve adinin belirlenmesi
           string source="Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\\Users\\Lenovo\\ZZDatabase\\dosya.accdb";
           
           //Veri tabani nesnesinin yaratilmasi (OleDbConnection sinifindan database baglanti kaynak nesnesinin yaratilmasi)
           OleDbConnection conn=new OleDbConnection(source);
           
           //Veri tabani kaynaginin acilmasi
           conn.Open();
           
           //veritabani  kayit alanlarina ekrandan okunan bilgilerin aktarilmasi
           string query="Insert Into Tablo1([adi],[soyadi],[numarasi],[burutmaas],[kesinti],[netmaas]) Values('" + textBox1.Text+ "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text +
           "','" + textBox5.Text + "','" + textBox6.Text + "')";
           
           //baglanti nesnesi ve sorgu stringi kullanilarak komut nesnesinin yaratilmasi
           OleDbCommand cmd= new OleDbCommand(query,conn);
           
           //komut nesnesinin isletilmesi ve veri tabanina yazilmasi
           MessageBox.Show(cmd.ExecuteNonQuery()+ "Kayit eklendi.");
           
           //veri tabani baglantisinin kesilmesi
           conn.Close();
        }
    }
}
