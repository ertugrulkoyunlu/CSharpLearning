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
namespace Database24
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source = C:\\Users\\Lenovo\\ZZDatabase\\elektrik2.accdb");
        DataTable Tablo1 = new DataTable();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        OleDbCommand cmd = new OleDbCommand();


        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.ShowDialog();
        }
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
            OleDbConnection conn2 = new OleDbConnection();
            OleDbCommand cmd2 = new OleDbCommand();
            OleDbCommand cmd3 = new OleDbCommand();
            OleDbDataReader dr;
            string a1, a2, a3, a4, a5, a6, a7, a8, a9;
            double harcama, meblag;

            conn2.ConnectionString = "Provider=Microsoft.Ace.OleDb.12.0;Data Source=C:\\Users\\Lenovo\\ZZDatabase\\elektrik.accdb";
            conn2.Open();
            cmd2 = conn2.CreateCommand();
            cmd2.CommandText = "select * From Tablo1";
            dr = cmd2.ExecuteReader();

            while (dr.Read())
            {
                a1 = "" + dr["adi"];
                a2 = "" + dr["soyadi"];
                a3 = "" + dr["adresi"];
                a4 = "" + dr["sayacno"];
                a5 = "" + dr["ilkendex"];
                a6 = "" + dr["sonendex"];
                a7 = "" + dr["aboneno"];

                harcama = (Convert.ToDouble(a6) - Convert.ToDouble(a5));
                meblag = harcama * 1.5;


                a8 = Convert.ToString(harcama);
                a9 = Convert.ToString(meblag);

                string source = "Provider=Microsoft.Ace.OleDb.12.0;Data Source =C:\\Users\\Lenovo\\ZZDatabase\\elektrik2.accdb";
                OleDbConnection conn3 = new OleDbConnection(source);
                conn3.Open();

                string query = "Insert Into Tablo1 ([adi],[soyadi],[adresi],[sayacno],[ilkendex],[sonendex],[aboneno],[harcama],[meblag])Values('" + a1 + "','" + a2 + "','" + a3 + "','" + a4 + "','" + a5 + "','" + a6 + "','" + a7
                + "','" + a8 + "','" + a9 + "')";
                OleDbCommand cmd4 = new OleDbCommand(query, conn3);
                MessageBox.Show(cmd4.ExecuteNonQuery() + "kayit eklendi");

            }
            conn2.Close();

            listele();
            dataGridView1.Columns[0].HeaderText = "adi";
            dataGridView1.Columns[1].HeaderText = "soadi";
            dataGridView1.Columns[2].HeaderText = "adresi";
            dataGridView1.Columns[3].HeaderText = "sayacno";
            dataGridView1.Columns[4].HeaderText = "ilkendex";
            dataGridView1.Columns[5].HeaderText = "sonendex";
            dataGridView1.Columns[6].HeaderText = "aboneno";
            dataGridView1.Columns[7].HeaderText = "harcama";
            dataGridView1.Columns[8].HeaderText = "meblag";
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            listele();
            dataGridView1.Columns[0].HeaderText = "adi";
            dataGridView1.Columns[1].HeaderText = "soadi";
            dataGridView1.Columns[2].HeaderText = "adresi";
            dataGridView1.Columns[3].HeaderText = "sayacno";
            dataGridView1.Columns[4].HeaderText = "ilkendex";
            dataGridView1.Columns[5].HeaderText = "sonendex";
            dataGridView1.Columns[6].HeaderText = "aboneno";
            dataGridView1.Columns[7].HeaderText = "harcama";
            dataGridView1.Columns[8].HeaderText = "meblag";
        }
    }
}
