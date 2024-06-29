using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Database6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int64 maas;
            OleDbCommand cmd;
            OleDbDataReader read;
            string source="Provider=Microsoft.Ace.OleDb.12.0;Data Source=C:\\Users\\Lenovo\\ZZDatabase\\dosya.accdb";
            OleDbConnection conn=new OleDbConnection(source);
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText= "select * from Tablo1";
            read=cmd.ExecuteReader();
            while (read.Read())
            {
               textBox1.Text = "" + read["adi"];
               textBox2.Text = "" + read["soyadi"];
               textBox3.Text = "" + read["numarasi"];
               textBox4.Text = "" + read["burutmaas"];
               textBox5.Text = "" + read["kesinti"];
               maas=Convert.ToInt64(textBox4.Text)+ Convert.ToInt64(textBox5.Text);
               textBox6.Text= Convert.ToString(maas);
               MessageBox.Show("sdaki");
            }
               MessageBox.Show("bitti");
        }
    }
}
    