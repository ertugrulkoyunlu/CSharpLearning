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
namespace Acces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lenovo\B.accdb");

        private void goruntule()
        {
            Console.Writeline("Deneme");
            listView1.Items.Clear();
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = ("Select * from Tablo1");
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = dr["id"].ToString();
                add.SubItems.Add(dr["ad"].ToString());
                add.SubItems.Add(dr["soyad"].ToString());
                add.SubItems.Add(dr["yas"].ToString());
                add.SubItems.Add(dr["ilce"].ToString());
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
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = ("Insert Into Tablo1 (id,ad,soyad,yas,ilce)Values('" + textBox5.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')");
            cmd.ExecuteNonQuery();
            conn.Close();
            goruntule();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from Tablo1 where id ='" + textBox5.Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            goruntule();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update Tablo1 set ad='" + textBox1.Text + "',soyad='" + textBox2.Text + "',yas='" + textBox3.Text + "',ilce='" + textBox4.Text + "'where id='" + textBox5.Text +"'";
            cmd.ExecuteNonQuery();
            conn.Close();
            goruntule();
        }
    }
}
