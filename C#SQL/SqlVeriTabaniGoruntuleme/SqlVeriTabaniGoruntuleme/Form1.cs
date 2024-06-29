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
namespace SqlVeriTabaniGoruntuleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-HVE6I3O8;Initial Catalog=Students;Integrated Security=True");
        private void goruntule()
        {
            listView1.Items.Clear();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from  bilgiler", conn);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                ListViewItem add = new ListViewItem();
                add.Text = dr["ad"].ToString();
                add.SubItems.Add(dr["sehir"].ToString());
                add.SubItems.Add(dr["okul"].ToString());
                add.SubItems.Add(dr["sehir"].ToString());
                listView1.Items.Add(add);
                
            }
            conn.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            goruntule();
        }
    }
}
