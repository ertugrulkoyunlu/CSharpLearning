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
namespace Database23
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source= C:\\Users\\Lenovo\\ZZDatabase\\elektrik3.accdb");
        DataTable Tablo1 = new DataTable();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        OleDbCommand cmd = new OleDbCommand();

        void listele()
        {
            Tablo1.Clear();
            conn.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From Tablo1", conn);
            adtr.Fill(Tablo1);
            dataGridView1.DataSource = Tablo1;
            adtr.Dispose();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection connect = new OleDbConnection();
            OleDbCommand cmd2 = new OleDbCommand();
            OleDbCommand cmd3 = new OleDbCommand();
            OleDbDataReader dr;
            string a1, a2, a3, a4, a5, a6, a7;
            connect.ConnectionString = "Provider=Microsoft.Ace.OleDb.12.0;Data Source= C:\\Users\\Lenovo\\ZZDatabase\\elektrik.accdb";
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandText = "Select * From Tablo1";
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                a1 = "" + dr["adi"];
                a2 = "" + dr["soyadi"];
                a3 = "" + dr["adresi"];
                a4 = "" + dr["sayacno"];
                a5 = "" + dr["ilkendex"];
                a6 = "" + dr["sonendex"];
                a7 = "" + dr["aboneno"];
                a5 = a6;

                string source = "Provider=Microsoft.Ace.OleDb.12.0;Data Source= C:\\Users\\Lenovo\\ZZDatabase\\elektrik3.accdb";
                OleDbConnection conn = new OleDbConnection(source);
                conn.Open();

                string query = "Insert Into Tablo1 ([adi],[soyadi],[adresi],[sayacno],[ilkendex],[sonendex],[aboneno])Values('" + a1 + "','" + a2 + "','" + a3 + "','" + a4 + "','" + a5 + "','" + a6 + "','"
                + a7 + "')";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                MessageBox.Show(cmd.ExecuteNonQuery() + "kayit aktarildi");
            }
            conn.Close();

            listele();
            dataGridView1.Columns[0].HeaderText = "adi";
            dataGridView1.Columns[1].HeaderText = "soyadi";
            dataGridView1.Columns[2].HeaderText = "adresi";
            dataGridView1.Columns[3].HeaderText = "sayacno";
            dataGridView1.Columns[4].HeaderText = "ilkendex";
            dataGridView1.Columns[5].HeaderText = "sonendex";
            dataGridView1.Columns[6].HeaderText = "aboneno";


        }

        private void Form6_Load(object sender, EventArgs e)
        {
            listele();
            dataGridView1.Columns[0].HeaderText = "adi";
            dataGridView1.Columns[1].HeaderText = "soyadi";
            dataGridView1.Columns[2].HeaderText = "adresi";
            dataGridView1.Columns[3].HeaderText = "sayacno";
            dataGridView1.Columns[4].HeaderText = "ilkendex";
            dataGridView1.Columns[5].HeaderText = "sonendex";
            dataGridView1.Columns[6].HeaderText = "aboneno";

        }
    }
}
