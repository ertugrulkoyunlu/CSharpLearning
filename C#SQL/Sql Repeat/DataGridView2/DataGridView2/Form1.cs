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
namespace DataGridView2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-HVE6I3O8;Initial Catalog=bilgi;Integrated Security=True");
        public void verilerigoster(string veriler)
        {
            SqlDataAdapter adtr= new SqlDataAdapter (veriler,conn);
            DataSet ds = new DataSet();
            adtr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster("Select * From Kisiler");
        }
    }
}
