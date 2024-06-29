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
namespace GP6K
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Cikmak istediginize emin misiniz", "Cikis islemi", MessageBoxButtons.YesNo);

            if (onay == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
                   
                OleDbConnection conn =new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Lenovo\\elektrik.accdb");
                conn.Open();
                OleDbCommand Query= new OleDbCommand("select ka,pw from Tablo5 Where ka=@ad and pw=@sifre",conn);
                Query.Parameters.AddWithValue("@ka",textBox1.Text);
                Query.Parameters.AddWithValue("@pw",textBox2.Text);
                OleDbDataReader dr;
                 dr = Query.ExecuteReader(); 

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Kullanici adi ve sifre bos birakilamaz","hata");
            }
            else
            {
                if (dr.Read())
                {
                    this.Hide();
                    Form8 form = new Form8();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Kullanici adi veya sifre yanlis");
                }
            }
            

            /*           
                    */
        }
    }
}
