using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;//1- Veritabnlarına erişmek için tanımlanmış sistem kütüphanesi

namespace GD2H
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int64 Maas;
            //try
            //{

            //2   - Komut  sınıfından sec nesnesinin oluşturulması
            OleDbCommand sec;
            //3   - Okuma  sınıfından oku nesnesinin oluşturulması
            OleDbDataReader oku;

            /*Not - Bir ya da birden fazla satırların sonuç olarak döneceği sorgularda
            OledbCommand’ ın ExecuteReader özelliği kullanılmaktadır. 
            ExecuteReader geriye OleDbDataReader tipinde veri döndürmektedir.
            OleDbDataReader, sadece okunabilir olarak kullanılmaktadır. */


            //4   - kaynak adında bir stringin oluşturulması
            string kaynak = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\\Users\\Lenovo\\dosya.accdb";

            //1.1 - kaynak bilgilerine bağlanmak için bağlantı nesnesinin oluşturulması
            OleDbConnection baglan = new OleDbConnection(kaynak);
            //6   - Veritabanının açılması 
            baglan.Open();

            //7   - Sec komutunun baglan nesnesi ile yetkilendirilmesi
            sec = baglan.CreateCommand();

            //8   - Sec komutununu  Text ifadesi ile verilmesi (ISCI tablosundaki tüm veri alanlarının seçilmesi)
            sec.CommandText = "select * from ISCI";

            //9   - sec komutunun işletilmesi ve sonucun oku nesnesine aktarılması
            oku = sec.ExecuteReader();

            //10  - bilgilerin veri tabanından bir kayıt şeklinde okunması ve textBox ifadelerine aktarılması
            while (oku.Read())
            {

                /*10  -*/

                textBox1.Text = "" + oku["Adi"];
                textBox2.Text = "" + oku["Soyadi"];
                textBox3.Text = "" + oku["Numarasi"];
                textBox4.Text = "" + oku["Burutmaas"];
                textBox5.Text = "" + oku["Kesinti"];
                Maas = Convert.ToInt64(textBox4.Text) + Convert.ToInt64(textBox5.Text);
                textBox6.Text = Convert.ToString(Maas);

                MessageBox.Show("Siradaki girdi"); //MessageBox sız çok hızlı geçer okunması zorlaşırmış.Bu ifade olmazsa sadec sondaki ifade gözükür ve biter .
                                                  // System.Threading.Thread.Sleep(3000);// milisaniye

            }
                MessageBox.Show("Okunacak veri kalmadi");
            //}
            /*  catch (Exception e1)
              {
                  MessageBox.Show("Okunacak veri kalmadi" + e1);
              }
             */
        }
    }
}

