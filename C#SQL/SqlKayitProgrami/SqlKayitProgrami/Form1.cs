using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SqlKayitProgrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-HVE6I3O8;Initial Catalog=Kayitlar;Integrated Security=True");
        private void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        private void verilerigoster()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From gelenler", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = dr["adsoyad"].ToString();
                add.SubItems.Add(dr["firma"].ToString());
                add.SubItems.Add(dr["telefon"].ToString());
                listView1.Items.Add(add);
            }
            conn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert Into gelenler (adsoyad,firma,telefon)Values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "')", conn);
            label1.Text = (cmd.ExecuteNonQuery() + "kayit eklendi");
            conn.Close();
            verilerigoster();
            temizle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete from gelenler  where adsoyad =("+textBox1.Text.ToString()+")" ,conn);
             cmd.ExecuteNonQuery();
            conn.Close();
            verilerigoster();
            temizle();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
