﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Database18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source= C:\\Users\\Lenovo\\ZZDatabase\\basari1.accdb");
        DataTable Tablo1 = new DataTable();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dr;

        OleDbConnection conn2 = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source= C:\\Users\\Lenovo\\ZZDatabase\\basari2.accdb");
        DataTable Tablo2 = new DataTable();
        OleDbDataAdapter adtr2 = new OleDbDataAdapter();
        OleDbCommand cmd2 = new OleDbCommand();
        OleDbDataReader dr2;

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
        void listele2()
        {
            Tablo2.Clear();
            conn2.Open();
            OleDbDataAdapter adtr2 = new OleDbDataAdapter("Select * From Tablo2", conn2);
            adtr2.Fill(Tablo2);
            dataGridView2.DataSource = Tablo2;
            adtr2.Dispose();
            conn2.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
            dataGridView1.Columns[0].HeaderText = "adi";
            dataGridView1.Columns[1].HeaderText = "soyadi";
            dataGridView1.Columns[2].HeaderText = "numara";
            dataGridView1.Columns[3].HeaderText = "vize1";
            dataGridView1.Columns[4].HeaderText = "vize2";
            dataGridView1.Columns[5].HeaderText = "final";

            listele2();
            dataGridView2.Columns[0].HeaderText = "adi";
            dataGridView2.Columns[1].HeaderText = "soyadi";
            dataGridView2.Columns[2].HeaderText = "numara";
            dataGridView2.Columns[3].HeaderText = "vize1";
            dataGridView2.Columns[4].HeaderText = "vize2";
            dataGridView2.Columns[5].HeaderText = "vizeort";
            dataGridView2.Columns[6].HeaderText = "final";
            dataGridView2.Columns[7].HeaderText = "basari";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //register
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "Insert Into Tablo1(adi,soyadi,numara,vize1,vize2,final)Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            MessageBox.Show(cmd.ExecuteNonQuery() + "kayit eklendi ");
            cmd.Dispose();
            conn.Close();
            listele();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //delete
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "delete From Tablo1 where numara =" + textBox3.Text;
            MessageBox.Show(cmd.ExecuteNonQuery() + "yazilan sayiya gore kayit silindi");
            conn.Close();
            listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            DataTable dt = new DataTable();
            OleDbDataAdapter adtr3 = new OleDbDataAdapter("Select * from Tablo1 where adi='" + textBox1.Text + "'", conn);
            adtr3.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            DataTable dt = new DataTable();
            OleDbDataAdapter adptr3 = new OleDbDataAdapter("Update Tablo1 Set adi ='" + textBox1.Text + "'Where numara=" + textBox3.Text, conn);
            adptr3.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            listele();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            DataTable dt = new DataTable();
            OleDbDataAdapter adptr3 = new OleDbDataAdapter("Select * from Tablo1 Where adi Like '%" + textBox7.Text + "%'", conn);
            adptr3.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbCommand cmd2 = new OleDbCommand();
            OleDbDataReader dr;

            double vizeort, basari;
            string vizeort2, basari2;

            conn.ConnectionString = "Provider=Microsoft.Ace.OleDb.12.0;Data Source = C:\\Users\\Lenovo\\ZZDatabase\\basari1.accdb";
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Tablo1";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = "" + dr["adi"];
                textBox2.Text = "" + dr["soyadi"];
                textBox3.Text = "" + dr["numara"];
                textBox4.Text = "" + dr["vize1"];
                textBox5.Text = "" + dr["vize2"];
                textBox6.Text = "" + dr["final"];

                vizeort = (Convert.ToDouble(textBox4.Text) + Convert.ToDouble(textBox5.Text)) / 2;
                vizeort2 = Convert.ToString(vizeort);

                basari = vizeort * 0.4 + Convert.ToDouble(textBox6.Text) * 0.6;
                basari2 = Convert.ToString(basari);
                string source = "Provider=Microsoft.Ace.OleDb.12.0;Data Source=C:\\Users\\Lenovo\\ZZDatabase\\basari2.accdb";
                OleDbConnection conn2 = new OleDbConnection(source);
                conn2.Open();
                string query = "Insert Into Tablo2([adi],[soyadi],[numara],[vize1],[vize2],[vizeort],[final],[basari]) Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','"
                + textBox5.Text + "','" + vizeort2 + "','" + textBox6.Text + "','" + basari2 + "')";
                OleDbCommand cmd3 = new OleDbCommand(query,conn2);
                MessageBox.Show(cmd3.ExecuteNonQuery()+ " tablo veri tabanina eklendi");
                conn2.Close();
                listele2();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
            }
        }
    }
}
