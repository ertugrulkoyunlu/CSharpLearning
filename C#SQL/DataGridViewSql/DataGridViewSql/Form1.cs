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
namespace DataGridViewSql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=laptop-hve6i3o8;Initial Catalog=Kutuphane;Integrated Security=True");
        public void goruntule(string veriler)
        {
            SqlDataAdapter adtr = new SqlDataAdapter(veriler, conn);
            DataSet ds = new DataSet();
            adtr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            goruntule("Select * from Kitaplar2");
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
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            goruntule("Select * from Kitaplar2");
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete from Kitaplar2 where ad =@adi", conn);
            cmd.Parameters.AddWithValue("@adi", textBox1.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            goruntule("Select * from Kitaplar2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update Kitaplar2 set yazar='" + textBox2.Text + "',sayfano='" + textBox3.Text + "',basimevi='" + textBox4.Text + "'where ad='" + textBox1.Text + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            goruntule("Select * from Kitaplar2");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Kitaplar2 where ad like '%" + textBox1.Text + "%'", conn);
            SqlDataAdapter adtr = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adtr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            string ad = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();
            string yazar = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string sayfano = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
            string basimevi = dataGridView1.Rows[secilialan].Cells[3].Value.ToString();

            textBox1.Text = ad;
            textBox2.Text = yazar;
            textBox3.Text = sayfano;
            textBox4.Text = basimevi;
        }
    }
}
