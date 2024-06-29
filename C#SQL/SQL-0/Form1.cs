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
using SQL_0.Classes;


namespace SQL_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand commandList = new SqlCommand("Select * from Table1", SqlOperations.connection);
            // text i tablo haline getirip adepte etmemiz lazım
            
            SqlOperations.CheckConnection(SqlOperations.connection);
            
            SqlDataAdapter da = new SqlDataAdapter(commandList);
            
            DataTable dt = new DataTable ();
            da.Fill(dt);
            
            dataGridView1.DataSource =dt;
             
        }

        private void tbrg_Click(object sender, EventArgs e)
        {
            SqlCommand commandAd =  new SqlCommand($"Insert into Table1(StudentName,StudentSurname,StudentUniNumber,StudentMail) values(@pname,@psurname,@pnumber,@pmail)",SqlOperations.connection);

            SqlOperations.CheckConnection(SqlOperations.connection);

            commandAdd.Parameters.AddWithValue("@pname",tbn.Text);
            commandAdd.Parameters.AddWithValue("@psurname",tbsn.Text);
            commandAdd.Parameters.AddWithValue("@pnumber",tbun.Text);
            commandAdd.Parameters.AddWithValue("@pmail",tbm.Text);
            commandAdd.ExecuteNonQuery();
        }
    }
}
