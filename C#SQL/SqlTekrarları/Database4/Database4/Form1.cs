using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Database4
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int64 maas;
            
            
          /*   try
             {*/
                OleDbCommand cmd;// komut sinifindan  cmd nesnesinin ol
                OleDbDataReader read;// okuma sinifindan oku olusturulumasi
                
                //   Bir ya da birden fazla satırların sonuç olarak döneceği sorgularda
                //    OledbCommand’ ın ExecuteReader özelliği kullanılmaktadır. 
                //   ExecuteReader geriye OleDbDataReader tipinde veri döndürmektedir.
                //   OleDbDataReader, sadece okunabilir olarak kullanılmaktadır. 
                
                // kaynak adinda bir string olusturulmasi
                string source="Provider=Microsoft.Ace.OleDb.12.0;Data Source=C:\\Users\\Lenovo\\ZZDatabase\\dosya.accdb";
                
                // kaynak bilgilerine baglanmak icin baglanti nesnesinin olusturulmasi
                OleDbConnection conn=new OleDbConnection(source);
          
                conn.Open();//Veritabaninin acilmasi
                cmd=conn.CreateCommand();//cmd komutunun baglan nesnesi ile  yetkilendirilmesi   
                 
                //Tablodaki butun verilerin secilmesi
    
                //cmd komutunun isletilmesi ve sonucun oku nesnesine aktarilmasi. operating cmd command and transerring result the read object.
                cmd.CommandText="Select *from Tablo1";
                
                // bilgilerin  veri tabanindan bir kayit seklinde okunmasi ve textbox ifadelere aktarilmasi
                read=cmd.ExecuteReader();
               
                while(read.Read())
                {
                textBox1.Text = "" + read["adi"];
                textBox2.Text = "" + read["soyadi"];
                textBox3.Text = "" + read["numarasi"];
                textBox4.Text = "" + read["burutmaas"];
                textBox5.Text = "" + read["kesinti"];
                
                maas=Convert.ToInt64(textBox4.Text)+Convert.ToInt64(textBox5.Text);
                textBox6.Text =Convert.ToString(maas);
                MessageBox.Show("Siradaki veriyi giriniz");
                }
                MessageBox.Show("Okunacak veri kalmadi");
                conn.Close();
             //}   
            
           /* //Bir hata ile karsilasilirsa hatanin yakalanmasi
            catch(InvalidOperationException)
            {
                MessageBox.Show("veri yok");
            }
           */     
        }
    }
}
