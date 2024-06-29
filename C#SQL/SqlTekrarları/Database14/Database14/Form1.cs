using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Database14
{
    public partial class Form1 : Form
    {
        int kod;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            OleDbDataReader reader;
            OleDbCommand cmd;

            conn.ConnectionString = "Provider=Microsoft.Ace.OleDb.12.0;Data Source=C:\\Users\\Lenovo\\ZZDatabase\\personel.accdb";
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Tablo1";
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                textBox1.Text = "" + reader["alan1"];
                textBox2.Text = "" + reader["alan2"];
                textBox3.Text = "" + reader["alan3"];
                textBox4.Text = "" + reader["alan4"];
                textBox5.Text = "" + reader["alan5"];
                textBox6.Text = "" + reader["alan6"];
                textBox7.Text = Convert.ToString(Convert.ToInt64(textBox5.Text) + Convert.ToInt64(textBox6.Text));

                kod = Convert.ToUInt16(textBox1.Text);
                if (kod == 1)
                {
                    string source1 = "Provider=Microsoft.Ace.OleDb.12.0;Data Source=C:\\Users\\Lenovo\\ZZDatabase\\personelbay.accdb";
                    OleDbConnection conn1 = new OleDbConnection(source1);
                    conn1.Open();
                    string query1 = "Insert Into Tablo1 ([cinsiyet],[adi],[soyadi],[sicilno],[calgun],[ucret],[toplam])Values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','"
                    + textBox4.Text + "','"+ textBox5.Text + "','"  + textBox6.Text + "','" + textBox7.Text + "')";
                    OleDbCommand cmd1 = new OleDbCommand(query1, conn1);
                    MessageBox.Show(cmd1.ExecuteNonQuery() + "kayit eklendi");
                    conn1.Close();

                }
                if (kod == 2)
                {
                    string source2 = "Provider=Microsoft.Ace.OleDb.12.0;Data Source=C:\\Users\\Lenovo\\ZZDatabase\\personelbayan.accdb";
                    OleDbConnection conn2 = new OleDbConnection(source2);
                    conn2.Open();
                    string query2 = "Insert Into Tablo1 ([cinsiyet],[adi],[soyadi],[sicilno],[calgun],[ucret],[toplam])Values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','"
                    + textBox4.Text + "','" +  textBox5.Text +"','" + textBox6.Text + "','" + textBox7.Text + "')";
                    OleDbCommand cmd2 = new OleDbCommand(query2, conn2);
                    MessageBox.Show(cmd2.ExecuteNonQuery() + "kayit ekledni");
                    conn2.Close();      



                }


            }


        }
    }
}