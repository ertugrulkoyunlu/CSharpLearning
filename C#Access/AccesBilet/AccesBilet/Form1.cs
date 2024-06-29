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
namespace AccesBilet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lenovo\accesbilet.accdb");
        OleDbCommand cmd = new OleDbCommand();
        private void goruntule()
        {
            listView1.Items.Clear();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "Select * from Tablo1";
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = dr["seferno"].ToString();
                add.SubItems.Add(dr["tarih"].ToString());
                add.SubItems.Add(dr["saat"].ToString());
                add.SubItems.Add(dr["adsoyad"].ToString());
                add.SubItems.Add(dr["telefon"].ToString());
                add.SubItems.Add(dr["koltukno"].ToString());
                add.SubItems.Add(dr["ucret"].ToString());
                add.SubItems.Add(dr["cinsiyet"].ToString());
                listView1.Items.Add(add);
            }
            conn.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            goruntule();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "Insert Into Tablo1 (seferno,tarih,saat,adsoyad,telefon,koltukno,ucret,cinsiyet)Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')";
            MessageBox.Show(cmd.ExecuteNonQuery()+"kayit eklendi.");
            conn.Close();
            goruntule();
            
        }
    }
}
