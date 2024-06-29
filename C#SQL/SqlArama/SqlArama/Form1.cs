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
namespace SqlArama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-HVE6I3O8;Initial Catalog=bilgi;Integrated Security=True");
        private void goruntule()
        {
            listView1.Items.Clear();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = " Select *from Kisiler";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = dr["ad"].ToString();
                add.SubItems.Add(dr["soyad"].ToString());
                add.SubItems.Add(dr["yas"].ToString());
                add.SubItems.Add(dr["ilce"].ToString());
                add.SubItems.Add(dr["meslek"].ToString());
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
            listView1.Items.Clear();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = " Select *from Kisiler where ad like '%"+textBox1.Text + "%'";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = dr["ad"].ToString();
                add.SubItems.Add(dr["soyad"].ToString());
                add.SubItems.Add(dr["yas"].ToString());
                add.SubItems.Add(dr["ilce"].ToString());
                add.SubItems.Add(dr["meslek"].ToString());
                listView1.Items.Add(add);
            }
            conn.Close();
        }
    }
}
