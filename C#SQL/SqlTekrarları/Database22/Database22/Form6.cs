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

namespace Database22
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        OleDbConnection conn1 = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source= C:\\Users\\Lenovo\\ZZDatabase\\elektrik3.accdb");
        DataTable Tablo1 = new DataTable();
        DataTable Tablo2 = new DataTable();
        OleDbDataAdapter adtr1 = new OleDbDataAdapter();
        OleDbCommand cmd1 = new OleDbCommand();

        
        void listele1()
        {
            Tablo1.Clear();
            conn1.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From Tablo1", conn1);
            adtr.Fill(Tablo1);
            dataGridView1.DataSource = Tablo1;
            adtr.Dispose();
            conn1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a1, a2, a3, a4, a5, a6, a7;
            OleDbConnection conn = new OleDbConnection();
            OleDbCommand cmd1 = new OleDbCommand();
            OleDbCommand cmd2 = new OleDbCommand();
            OleDbDataReader dr;

            conn.ConnectionString = "Provider=Microsoft.Ace.OleDb.12.0;Data Source= C:\\Users\\Lenovo\\ZZDatabase\\elektrik.accdb";
            conn.Open();
            cmd1 = conn.CreateCommand();
            cmd1.CommandText = "Select * From Tablo1";
            dr = cmd1.ExecuteReader();

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
                OleDbConnection conn2 = new OleDbConnection(source);

                conn2.Open();
                string query = "Insert Into Tablo1([adi],[soyadi],[adresi],[sayacno],[ilkendex],[sonendex],[aboneno])Values('" + a1 + "','" + a2 + "','" + a3 + "','" + a4 + "','" + a5 + "','" + a6 + "','" + a7 + "')";
                OleDbCommand cmd = new OleDbCommand(query, conn2);
                MessageBox.Show(cmd.ExecuteNonQuery() + "kayit aktarildi");
            }

            conn.Close();
            listele1();
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
        
            listele1();
            dataGridView1.Columns[0].HeaderText = "adi";
            dataGridView1.Columns[1].HeaderText = "soyadi";
            dataGridView1.Columns[2].HeaderText = "adresi";
            dataGridView1.Columns[3].HeaderText = "sayacno";
            dataGridView1.Columns[4].HeaderText = "ilkendex";
            dataGridView1.Columns[5].HeaderText = "sonendex";
            dataGridView1.Columns[6].HeaderText = "aboneno";

        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listele1();
            
        }
    }
}
