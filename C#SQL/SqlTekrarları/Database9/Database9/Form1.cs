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
namespace Database9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string source = "Provider=Microsoft.Ace.OleDb.12.0;Data Source =C:\\Users\\Lenovo\\ZZDatabase\\personel.accdb";
            OleDbConnection conn = new OleDbConnection(source);
            conn.Open();
            string query = "Insert Into Tablo1 ([alan1],[alan2],[alan3],[alan4],[alan5],[alan6]) Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text +
            "','" + textBox6.Text + "')";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            MessageBox.Show(cmd.ExecuteNonQuery() + "kayit eklendi");
            conn.Close();
        }
    }
}
