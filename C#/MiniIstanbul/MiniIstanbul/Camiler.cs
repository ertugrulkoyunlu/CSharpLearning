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
namespace MiniIstanbul
{
    public partial class Camiler : Form
    {
        public Camiler()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lenovo\OneDrive\Masaüstü\cami.accdb");
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * from Tablo1";
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                richTextBox1.Text = dr["sultanahmet"].ToString();
            }
            webBrowser1.Navigate("https://www.google.com/maps/place/Sultanahmet,+Alemdar,+34110+Fatih%2F%C4%B0stanbul/@41.0078737,28.9778313,15z/data=!3m1!4b1!4m6!3m5!1s0x14cab9bddcd032e9:0x485518afab977da6!8m2!3d41.0078742!4d28.9778313!16s%2Fg%2F11hbt4rbh5?entry=ttu");
            webBrowser1.ScriptErrorsSuppressed = true;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * from tablo1";
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                richTextBox1.Text = dr["yenicami"].ToString();
            }
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * from tablo1";
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                richTextBox1.Text = dr["ayasofya"].ToString();
            }
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * from tablo1";
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                richTextBox1.Text = dr["ortakoy"].ToString();
            }
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * from tablo1";
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                richTextBox1.Text = dr["fatih"].ToString();
            }
            
            conn.Close();
        }
    }
}
