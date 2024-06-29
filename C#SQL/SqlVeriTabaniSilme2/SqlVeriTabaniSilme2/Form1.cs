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
namespace SqlVeriTabaniSilme2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=laptop-hve6i3o8;Initial Catalog=Kutuphane;Integrated Security=True");
        private void goruntule()
        {
            listView1.Items.Clear();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from kitaplar ", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = dr["id"].ToString();
                add.SubItems.Add(dr["kitapad"].ToString());
                add.SubItems.Add(dr["yazar"].ToString());
                add.SubItems.Add(dr["yayinevi"].ToString());
                add.SubItems.Add(dr["sayfa"].ToString());
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
            SqlCommand cmd = new SqlCommand("Insert Into kitaplar (id,kitapad,yazar,yayinevi,sayfa)Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" +
            textBox4.Text + "','" + textBox5.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            goruntule();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
        int id = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete from kitaplar where id =(" + id + ")", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            goruntule();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = int .Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[4].Text;
        }
    }
}
