using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; //1- Veritabanlarına erişmek için tanımlanmış sistem kütüphanesi
namespace GD1H
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    
        

















       private void button1_Click(object sender, EventArgs e)
        {
            //2-Veri tabanı cinsi,sürümü,dosya yolu ve adının belirlenmesi
            /*2-*/string kaynak = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source = C:\\Users\\Lenovo\\dosya.accdb";
            
            //3-Veri tabanı nesenesinin yaratılması(OleDbConnection sınıfından database bağlantı kaynak nesnesinin yaratılması)
            /*3-*/OleDbConnection baglanti=new OleDbConnection(kaynak);
            
            //4-Veri tabanı kaynağının açılması
            /*4-*/baglanti.Open();
            
            //5-Veri tabanı kayıt alanlarına ekrandan okunan bilgilerin aktarılması
            /*5-*/string sorgu ="Insert Into Iscı([Adi],[Soyadi],[Numarasi],[Burutmaas],[Kesinti])Values('" + textBox1.Text +
            "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            
            //6-Bağlantı nesnesi ve sorgu stringi kullanılarak komut nesnesinin yaratılması
            /*6-*/OleDbCommand komut =new OleDbCommand(sorgu,baglanti);
            
            //7-Komut nesnesinin işletilmesi ve veri tabanına yazılması
            /*7-*/MessageBox.Show(komut.ExecuteNonQuery() + " Kayit eklendi. " );

            //8-Veri tabanının bağlantısının kesilimesi
            /*8-*/baglanti.Close();
        }
    }
}
