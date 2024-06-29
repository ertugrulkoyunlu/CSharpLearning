using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Database12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int64 maas;
            OleDbCommand cmd;// komut sinifinda cmd nesnesinin olusturulmasi(cmd object creating in command class)
            OleDbDataReader reader;// komut sinifinda read nesnesinin olusturulmasi(read object creating in command class)
            string source = "Provider=Microsoft.Ace.OleDb.12.0;Data Source=C:\\Users\\Lenovo\\ZZDatabase\\dosya.accdb";
            OleDbConnection conn = new OleDbConnection(source);
            conn.Open();
            cmd = conn.CreateCommand();//cmd komutunun conn nesnesi  ile yetkilendirilmesi(cmd command  authorization  with conn object)
            cmd.CommandText = "Select * from Tablo1";
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                textBox1.Text = "" + reader["adi"];
                textBox2.Text = "" + reader["soyadi"];
                textBox3.Text = "" + reader["numarasi"];
                textBox4.Text = "" + reader["burutmaas"];
                textBox5.Text = "" + reader["kesinti"];
                maas= Convert.ToInt64(textBox4.Text)+Convert.ToInt64(textBox5.Text);
                textBox6.Text= Convert.ToString(maas);
                MessageBox.Show("a");
            }
                MessageBox.Show("Okunacak veri kalmadi");
            conn.Close();

        }
    }

}