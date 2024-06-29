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

namespace GP6K
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Lenovo\\elektrik.accdb");
        DataTable Tablo1 = new DataTable();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        OleDbCommand cmd1 = new OleDbCommand();

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
            dataGridView1.Columns[1].HeaderText = "Adi";
            dataGridView1.Columns[2].HeaderText = "Soyadi";
            dataGridView1.Columns[3].HeaderText = "Adresi";
            dataGridView1.Columns[4].HeaderText = "sayacno";
            dataGridView1.Columns[5].HeaderText = "ilkendex";
            dataGridView1.Columns[6].HeaderText = "sonendex";
            dataGridView1.Columns[7].HeaderText = "Aboneno";
        }

        private void fnd_Click(object sender, EventArgs e)
        {
            conn.Open();
            DataTable dt = new DataTable();
            OleDbDataAdapter adptr = new OleDbDataAdapter("Select * From Tablo1 where Aboneno=" + textBox1.Text + "", conn);
            adptr.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void dlt_Click(object sender, EventArgs e)
        {
            cmd1.Connection = conn;
            conn.Open();
            cmd1.CommandText = "delete from Tablo1 where Aboneno=" + textBox1.Text + "";
            MessageBox.Show(cmd1.ExecuteNonQuery() + "Kayit Silindi");
            conn.Close();
            listele();
            
        }

        private void list_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 form =new Form8();
            form.ShowDialog();
        }
    }
}
