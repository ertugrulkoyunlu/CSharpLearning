using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Database11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string source = "Provider=Microsoft.Ace.OleDb.12.0;Data Source=C:\\Users\\Lenovo\\ZZDatabase\\dosya.accdb";
            OleDbConnection conn = new OleDbConnection(source);
            conn.Open();
            string query = "Insert Into Tablo1([adi],[soyadi],[numarasi],[burutmaas],[kesinti])Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" +
            textBox5.Text + "')";
            OleDbCommand cmd =new OleDbCommand(query,conn);
            MessageBox.Show(cmd.ExecuteNonQuery()+"kayit eklendi");
            conn.Close();
        }
    }


}