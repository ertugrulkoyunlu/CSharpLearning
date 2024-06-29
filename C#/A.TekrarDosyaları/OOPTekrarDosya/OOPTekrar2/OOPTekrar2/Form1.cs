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

namespace OOPTekrar2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-HVE6I3O8;Initial Catalog=Sepet;Integrated Security=True");
        private void goruntule()
        {
            listView1.Items.Clear();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From Telefon", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = dr["ad"].ToString();
                add.SubItems.Add(dr["fiyat"].ToString());
                add.SubItems.Add(dr["marka"].ToString());
                listView1.Items.Add(add);
            }
            conn.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {


            Sepet spt = new Sepet();
            Ekmek ekm = new Ekmek(textBox1.Text.ToString(), Convert.ToDouble(textBox2.Text), textBox3.Text.ToString(), Convert.ToInt32(textBox4.Text.ToString()));
            spt.Urunekle(ekm);
            MessageBox.Show(spt.toplamtutar().ToString());
            richTextBox1.Text = textBox1.Text.ToString() + "\n" + textBox2.Text.ToString() + "\n" + textBox3.Text.ToString() + "\n" + textBox4.Text.ToString();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Sepet spt = new Sepet();
            CepTelefonu tlfn = new CepTelefonu(textBox1.Text.ToString(), Convert.ToDouble(textBox2.Text), textBox3.Text.ToString());
            spt.Urunekle(tlfn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert Into Telefon(ad,fiyat,marka)Values('" + textBox1.Text.ToString() + "','" + spt.toplamtutar().ToString() + "','" + textBox3.Text.ToString() + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            goruntule();

            MessageBox.Show(spt.toplamtutar().ToString());
            richTextBox2.Text = textBox1.Text.ToString() + "\n" + spt.toplamtutar().ToString() + "\n" + textBox3.Text.ToString();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            goruntule();
        }
    }
}
