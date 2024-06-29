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
namespace DatabaseSeparation
{
    public partial class Form1 : Form
    {
        float KOD;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //////   Bilginin personel.accdb tablosundan okunması  
            OleDbConnection baglan = new OleDbConnection(); //OleDbConnection sınıfından veritabanı ile bağlantı sağlayacak nesnenin oluşturulması 
            OleDbCommand sec; // OleDbCommand sınıfından komut olarak kullanılacak nesnenin oluşturulması
            OleDbDataReader oku; // OleDbDataReader sınıfından veritabanı bilgisini okuyacak nesnenin oluşturulması 


            baglan.ConnectionString = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\\Users\\Lenovo\\personel.accdb";
            baglan.Open();
            sec = baglan.CreateCommand(); // sec nesnesine, baglan nesnesi aracılığı ile komutun oluşturulması ve atanması 
            sec.CommandText = "select * from Tablo1"; // sec nesnesine tablo bilgilerinin aktarılması
            oku = sec.ExecuteReader();  // oku nesnesine veritabanındaki bilgilerin okunması yetkisinin verilmesi
            while (oku.Read()) // veritabanı bilgilerinin okunması ve 
            {
                textBox1.Text = " " + oku["alan1"];   // textBoxlara aktarılması
                textBox2.Text = " " + oku["alan2"];
                textBox3.Text = " " + oku["alan3"];
                textBox4.Text = " " + oku["alan4"];
                textBox5.Text = " " + oku["alan5"];
                textBox6.Text = " " + oku["alan6"];
                textBox7.Text = Convert.ToString(Convert.ToInt64(textBox5.Text) * Convert.ToInt64(textBox6.Text));

                ///////////////Bilginin baylara ait olduğunun saptanması ve personelBAY.accdb  dosyasına yazılması 


                KOD = Convert.ToInt64(textBox1.Text);
                if (KOD == 1)
                {
                    string kaynak1 = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source =C:\\Users\\Lenovo\\personelBay.accdb";
                    OleDbConnection baglanti1 = new OleDbConnection(kaynak1);
                    baglanti1.Open();
                    string sorgu1 = "Insert Into Tablo2([cinsiyet],[adi],[soyadi],[sicilno],[calgun],[ucret],[toplam])Values('" +
                    textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text +
                    "','" + textBox6.Text + "','" + textBox7.Text + "')"; // texBox5.Text + "','" koymayı unutursan sorgu değerleri eşit olmaz.
                    OleDbCommand komut1 = new OleDbCommand(sorgu1, baglanti1);
                    MessageBox.Show(komut1.ExecuteNonQuery() + " Kayit cinsiyete göre ayrildi ve eklendi.");
                    baglanti1.Close();
                }

                //  Bilginin bayanlara ait olduğunun saptanması ve personelBAYAN.accdb  dosyasına yazılması 

                if (KOD == 2)
                {
                    string kaynak2 = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source = C:\\Users\\Lenovo\\personelBayan.accdb";
                    OleDbConnection baglanti2 = new OleDbConnection(kaynak2);
                    baglanti2.Open();
                    string sorgu2 = " Insert Into Tablo3([cinsiyet],[adi],[soyadi],[sicilno],[calgun],[ucret],[toplam])Values('" +
                    textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text +
                    "','" + textBox6.Text + "','" + textBox7.Text + "')";
                    OleDbCommand komut2 = new OleDbCommand(sorgu2, baglanti2);
                    MessageBox.Show(komut2.ExecuteNonQuery() + "Kayit cinsiyete göre ayrildi ve eklendi ");
                    baglanti2.Close();

                }

            }
            MessageBox.Show("Okunacak Kayit Kalmadi");
        }
    }
}
