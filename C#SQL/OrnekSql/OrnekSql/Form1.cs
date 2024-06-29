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
namespace OrnekSql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-HVE6I3O8;Initial Catalog=Personel;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from KisiBilgi", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand kayitekle = new SqlCommand("Insert Into KisiBilgi(Numarasi,Ad,Soyad,Sehir)Values(@p1,@p2,@p3,@p4)", conn);
            kayitekle.Parameters.AddWithValue("@p1", textBox1.Text);
            kayitekle.Parameters.AddWithValue("@p2", textBox2.Text);
            kayitekle.Parameters.AddWithValue("@p3", textBox3.Text);
            kayitekle.Parameters.AddWithValue("@p4", textBox4.Text);
            kayitekle.ExecuteNonQuery();
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand kayitsil = new SqlCommand("Delete from KisiBilgi where Ad=@adi", conn);
            kayitsil.Parameters.AddWithValue("adi", textBox2.Text);
            kayitsil.ExecuteNonQuery();
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand guncelle = new SqlCommand("update KisiBilgi set Numarasi=@p1,Ad=@p2,Soyad=@p3,Sehir=@p4 where Numarasi=@p1", conn);
            guncelle.Parameters.AddWithValue("@p1", textBox1.Text);
            guncelle.Parameters.AddWithValue("@p2", textBox2.Text);
            guncelle.Parameters.AddWithValue("@p3", textBox3.Text);
            guncelle.Parameters.AddWithValue("@p4", textBox4.Text);
            guncelle.ExecuteNonQuery();
            conn.Close(); 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string no = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            string ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            string soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            string sehir = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            textBox1.Text = no;
            textBox2.Text = ad;
            textBox3.Text = soyad;
            textBox4.Text = sehir;
        }
    }
}
