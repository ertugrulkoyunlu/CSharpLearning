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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        OleDbConnection conn = new OleDbConnection("Provider= Microsoft.Ace.OleDb.12.0;Data Source = C:\\Users\\Lenovo\\ZZDatabase\\elektrik.accdb");
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


        private void Form3_Load(object sender, EventArgs e)
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


        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            DataTable dt = new DataTable();
            OleDbDataAdapter adtr3 = new OleDbDataAdapter("Select * From Tablo1 Where aboneno=" + textBox1.Text, conn);

            adtr3.Fill(dt);
            dataGridView1.DataSource = dt;
            adtr3.Dispose();
            conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;
            
            cmd.CommandText = "Delete * From Tablo1 where aboneno="+textBox1.Text;
            MessageBox.Show(cmd.ExecuteNonQuery()+"bir kayit silindi");
            conn.Close();
            listele();
        }
    }
}
