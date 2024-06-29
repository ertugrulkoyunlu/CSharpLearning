using System;
using System.Data.OleDb;        //Veri tabanlarina erismek icin tanimlanmis sistem kutuphanesi.                                
using System.Windows.Forms;     //Identified system library for access-ing the databases.  If acces with write tanimlanan but if write acces-ing tanimlanmis.
namespace GDHR1                 //Defined    system library for accesing databases.
{
    public partial class Form1 : Form
    {
        public Form1()
        {
        InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        
        //Veri tabani cinsi,surumu,dosya yolu ve adinin belirlenmesi.
        //Determining the database type,version,folder path and name.
        
        string kaynak="Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C\\Users\\Lenovo\\.accdb";

        
        //Veri tabani nesnesinin yaratilmasi. ( OleDbConnection sinifindan database baglanti nesnesinin yaratilmasi )
        //Creation database object.           ( Creation database connection object from OleDbConnection class. )
        OleDbConnection baglanti=new OleDbConnection(kaynak);
        
        
        //Veri tabani kaynaginin acilmasi
        //Opening the database resource.resource and ource meaning kaynak
        
        baglanti.Open();
        
        
        //Veri kayit alanlarina ekrandan okunan bilgilerin aktarilmasi
        //Transfering information read from the screen to  data recording fields 
        
        string sorgu ="Insert Into Isci([Adi],[Soyadi],[Numarasi],[Burutmaas][Kesinti])Values('" +textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text +
        "','" +textBox5.Text +"')";
        //Baglanti nesnesi ve sorgu stringi kullanilarak nesnenin yaratilmasi
        //Object creation using query string and connection object //Object creation using connection object and query string.  {  nesne=object query=sorgu class=sinif }
        OleDbCommand komut = new OleDbCommand(sorgu,baglanti);
        
        
        /*Komut nesnesinin isletilmesi ve veri tabanina yazilmasi 
          Operating command class and writing database.
          Executing command class and writi
        
        Bu metod geriye int olarak update, insert, delete olaylarından etkilenen satır sayısı döndürüyor.
        DDL ve DML komutları için geliştirilmiştir diyebiliriz. Tamamiyle veri kaynağı üzerinde bir takım sonuçların doğmasına yardımcı olurlar. Bu tip komut cümlecikleri için, ExecuteNonQuery        
        
        This method returns as an int the number of rows affected by the update, insert, delete events.
        We can say that it has been developed for DDL and DML commands. They help to produce some results entirely on the data source. For this type of command clause, ExecuteNonQuery*/
        
        MessageBox.Show(komut.ExecuteNonQuery() + " kayit eklendi. " );    
        
        
        //Veritabaninin baglantisinin kesilmesi
        //Database disconnection
        baglanti.Close();
    
        }
    }


}
/*
using System;
using System.Data.OleDb;
using System.Windows.Forms;
namespace GDHR1
{
    public partial class Form1:Form
    {
        public Form1
        {
        InitializeComponent();
        }

    string kaynak ="Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Lenovo\\accdb";

    OleDbConnection baglanti = new OleDbConnection(kaynak);
    
    baglanti.Open();

    string sorgu ="Insert Into Tablo1([Adi],[Soyadi],[Numarasi],[Burutmaas],[Kesinti])Values('" + textBox1.Text + "','" +textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text +
    "','" +textBox5.Text+ "','" +textBox6.Text + "')"; 
    
    
    }


    }
        
}
*/
