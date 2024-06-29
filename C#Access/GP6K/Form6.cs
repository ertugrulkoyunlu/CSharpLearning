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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        OleDbConnection conn2 = new OleDbConnection("Provider=Microsft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Lenovo\\elektrik2.accdb");
        DataTable Tablo2 = new DataTable();
        OleDbDataAdapter adr2 = new OleDbDataAdapter();
        OleDbCommand cmd2 = new OleDbCommand();



        void listele2()
        {
            Tablo2.Clear();
            conn2.Open();
            OleDbDataAdapter adr2 = new OleDbDataAdapter("select * from Tablo2", conn2);
            adr2.Fill(Tablo2);
            dataGridView1.DataSource = Tablo2;
            adr2.Dispose();
            conn2.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a1, a2, a3, a4, a5, a6, a7, a8, a9;
            OleDbConnection conn = new OleDbConnection();
            OleDbCommand select = new OleDbCommand();
            OleDbCommand add = new OleDbCommand();
            OleDbDataReader read;
            double endex, meblag;

            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Lenovo\\elektrik.accdb";

            conn.Open();
            select = conn.CreateCommand();
            select.CommandText = "select * from Tablo1";
            read = select.ExecuteReader();

            while (read.Read())
            {
                a1 = "" + read["Adi"];
                a2 = "" + read["Soyadi"];
                a3 = "" + read["Adresi"];
                a4 = "" + read["sayacno"];
                a5 = "" + read["ilkendex"];
                a6 = "" + read["sonendex"];
                a7 = "" + read["Aboneno"];

                endex = Convert.ToDouble(a6) - Convert.ToDouble(a5);
                meblag = endex * 1.5;
                a8 = Convert.ToString(endex);
                a9 = Convert.ToString(meblag);

                string source = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Lenovo\\elektrik2.accdb";
                OleDbConnection connection = new OleDbConnection(source);
                connection.Open();
                

                string query = "Insert Into tablo2([adi],[Soyadi],[Adresi],[sayacno],[ilkendex],[sonendex],[Aboneno],[Harcama],[Meblag])Values('" + a1 + "','" + a2 + "','" + a3 + "','" + a4 + "','" + a5 + "','" + a6 + "','" + a7 + "','" + a8 + "','" + a9 + "','" + "')";
                
            }
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 form = new Form8();
            form.ShowDialog();
        }
    }
}
