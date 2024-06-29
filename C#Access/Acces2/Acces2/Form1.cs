using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Acces2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lenovo\B.accdb");
        OleDbCommand cmd = new OleDbCommand();

        private void goruntule()
        {
            listView1.Items.Clear();
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = ("Select * from Tablo1");
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = dr["id"].ToString();
                add.SubItems.Add(dr["ad"].ToString());
                add.SubItems.Add(dr["soyad"].ToString());
                add.SubItems.Add(dr["yas"].ToString());
                add.SubItems.Add(dr["ilce"].ToString());
                listView1.Items.Add(add);
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd.Connection = conn;
            conn.Open();

            cmd.CommandText = "delete from Tablo1 where id= '" + a.Text + "'";
            MessageBox.Show(cmd.CommandText);
            cmd.ExecuteNonQuery();
            conn.Close();
            goruntule();
            listView1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            goruntule();
        }
    }
}
