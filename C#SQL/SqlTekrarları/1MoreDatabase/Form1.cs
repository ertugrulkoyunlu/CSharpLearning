using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace _1MoreDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kaynak = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\\Users\\Lenovo\\personel.accdb";
            OleDbConnection baglanti =new OleDbConnection(kaynak); 
            baglanti.Open();
            string sorgu = "Insert Into Tablo1([alan1],[alan2],[alan3],[alan4],[alan5],[alan6]) Values('"  + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text+ "'    )"; 
            OleDbCommand komut = new OleDbCommand(sorgu,baglanti);
            MessageBox.Show(komut.ExecuteNonQuery ()+"KayitEklendi.");
            baglanti.Close();
            
        }
    }
}