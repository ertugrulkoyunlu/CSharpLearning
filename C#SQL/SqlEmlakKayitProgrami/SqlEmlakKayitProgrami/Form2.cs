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
namespace SqlEmlakKayitProgrami
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-HVE6I3O8;Initial Catalog=siteler;Integrated Security=True");
        private void goruntule()
        {
            listView1.Items.Clear();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From sitebilgi", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = dr["id"].ToString();
                add.SubItems.Add(dr["site"].ToString());
                add.SubItems.Add(dr["oda"].ToString());
                add.SubItems.Add(dr["metre"].ToString());
                add.SubItems.Add(dr["fiyat"].ToString());
                add.SubItems.Add(dr["blok"].ToString());
                add.SubItems.Add(dr["no"].ToString());
                add.SubItems.Add(dr["adsoyad"].ToString());
                add.SubItems.Add(dr["telefon"].ToString());
                add.SubItems.Add(dr["notlar"].ToString());
                add.SubItems.Add(dr["satkira"].ToString());
                listView1.Items.Add(add);
            }
            conn.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Zambak Sitesi")
            {
                button5.BackColor = Color.Yellow;
                button3.BackColor = Color.Gray;
                button6.BackColor = Color.Gray;
                button7.BackColor = Color.Gray;
            }
            if (comboBox1.Text == "Papatya Sitesi")
            {
                button7.BackColor = Color.White;
                button3.BackColor = Color.Gray;
                button6.BackColor = Color.Gray;
                button5.BackColor = Color.Gray;
            }
            if (comboBox1.Text == "Gul Sitesi")
            {
                button6.BackColor = Color.Red;
                button3.BackColor = Color.Gray;
                button5.BackColor = Color.Gray;
                button7.BackColor = Color.Gray;
            }
            if (comboBox1.Text == "Menekse Sitesi")
            {
                button3.BackColor = Color.Purple;
                button5.BackColor = Color.Gray;
                button6.BackColor = Color.Gray;
                button7.BackColor = Color.Gray;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            goruntule();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert Into sitebilgi (id,site,oda,metre,fiyat,blok,no,adsoyad,telefon,notlar,satkira)Values('" + textBox7.Text.ToString() + "','"
            + comboBox1.Text.ToString() + "','" + comboBox3.Text.ToString() + "','" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString()
            + "','" + comboBox4.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() +
            "','" + textBox3.Text.ToString() + "','" + comboBox2.Text.ToString() + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            goruntule();
        }
        
        private void button10_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete from sitebilgi where id =(" + id + ")", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            goruntule();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox7.Text = listView1.SelectedItems[0].SubItems[0].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            comboBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[4].Text;
            comboBox4.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[7].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[8].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[9].Text;
            comboBox2.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }
        int id = 0;
        private void button11_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update sitebilgi set id ='" + textBox7.Text.ToString() + "',site='" + comboBox1.Text.ToString() + "',oda='" + comboBox3.Text.ToString()
             + "',metre='" + textBox1.Text.ToString() + "',fiyat='" + textBox2.Text.ToString() +
             "',blok= '" + comboBox4.Text.ToString() + "',no='" + textBox6.Text.ToString() + "',adsoyad ='" + textBox4.Text.ToString() +
             "',telefon='" + textBox5.Text.ToString() +"',notlar='" + textBox3.Text.ToString() + "',satkira = '" + comboBox2.Text.ToString() + "'where id =(" + id + ")", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            goruntule();
        }
    }
}
