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
namespace DataGridViewEklemeSilme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=laptop-hve6i3o8;Initial Catalog=Kutuphane;Integrated Security=True");
        public void verilerigoster(string veriler)
        {
            SqlDataAdapter adtr = new SqlDataAdapter(veriler, conn);
            DataSet ds = new DataSet();
            adtr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster("select * from Kitaplar2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert Into Kitaplar2 (ad,yazar,sayfano,basimevi)Values(@adi,@yazari,@sayfanosu,@basimyeri)", conn);
            cmd.Parameters.AddWithValue("@adi", textBox1.Text);
            cmd.Parameters.AddWithValue("@yazari", textBox2.Text);
            cmd.Parameters.AddWithValue("@sayfanosu", textBox3.Text);
            cmd.Parameters.AddWithValue("@basimyeri", textBox4.Text);
            cmd.ExecuteNonQuery();
            verilerigoster("select * from Kitaplar2");
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete from Kitaplar2 where ad=@adi", conn);
            cmd.Parameters.AddWithValue("@adi", textBox1.Text);
            cmd.ExecuteNonQuery();
            verilerigoster("select * from Kitaplar2");
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Kitaplar2 where ad like '%" +textBox5.Text + "%'",conn);
            SqlDataAdapter adtr = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adtr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }
    }
}
