using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DataGrIdView1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "sirano";
            dataGridView1.Columns[1].Name = "ad";
            dataGridView1.Columns[2].Name = "soyad";
            dataGridView1.Columns[3].Name = "meslek";
            dataGridView1.Columns[4].Name = "sehir";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.Rows.Add(3);
            i = 0;
            dataGridView1.Rows[i].Cells[0].Value = 1;
            dataGridView1.Rows[i].Cells[1].Value = "ertugrul";
            dataGridView1.Rows[i].Cells[2].Value = "koyunlu";
            dataGridView1.Rows[i].Cells[3].Value = "programci";
            dataGridView1.Rows[i].Cells[4].Value = "adana";
            i = 1;
            dataGridView1.Rows[i].Cells[0].Value = 2;
            dataGridView1.Rows[i].Cells[1].Value = "ayse";
            dataGridView1.Rows[i].Cells[2].Value = "koyunlu";
            dataGridView1.Rows[i].Cells[3].Value = "dikis";
            dataGridView1.Rows[i].Cells[4].Value = "adana";
            i = 2;
            dataGridView1.Rows[i].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[i].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[i].Cells[2].Value = textBox3.Text;
            dataGridView1.Rows[i].Cells[3].Value = textBox4.Text;
            dataGridView1.Rows[i].Cells[4].Value = comboBox1.Text;
           
        }
    }
}
