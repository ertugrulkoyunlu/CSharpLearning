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
namespace SqlOyunlar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-HVE6I3O8;Initial Catalog=sorular;Integrated Security=True");

        int sayac = 0;
        int puan = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Text = "sonraki";
            textBox1.Clear();
            sayac++;
            label4.Text = sayac.ToString();
            if (sayac == 1)
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from soru order by NEWID()", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    button1.Text = (dr["a"].ToString());
                    button2.Text = (dr["b"].ToString());
                    button3.Text = (dr["c"].ToString());
                    button4.Text = (dr["d"].ToString());
                    textBox1.Text = (dr["soru"].ToString());
                    label3.Text = (dr["dogru"].ToString());
                }
                conn.Close();
            }
            if (sayac == 2)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from soru2 order by NEWID()", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    button1.Text = (dr["a"].ToString());
                    button2.Text = (dr["b"].ToString());
                    button3.Text = (dr["c"].ToString());
                    button4.Text = (dr["d"].ToString());
                    textBox1.Text = (dr["soru"].ToString());
                    label3.Text = (dr["dogru"].ToString());
                }
                conn.Close();

            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label4.Text = sayac.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            if (button1.Text == label3.Text)
            {
                puan = puan + 10;
                label2.Text = puan.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            if (button2.Text == label3.Text)
            {
                puan = puan + 10;
                label2.Text = puan.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            if (button3.Text == label3.Text)
            {
                puan = puan + 10;
                label2.Text = puan.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            if (button4.Text == label3.Text)
            {
                puan = puan + 10;
                label2.Text = puan.ToString();
            }
        }
    }
}
