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
namespace IlkProjeDenemesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=laptop-hve6i3o8;Initial Catalog=sorular;Integrated Security=True");
        int sayac = 0;
        private bool label2WasClicked = false;
        private bool label3WasClicked = false;
        private bool label5WasClicked = false;
        private bool label9WasClicked = false;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            timer1.Enabled = true;
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            int x2 = pictureBox2.Location.X;
            int y2 = pictureBox2.Location.Y;


            if (e.KeyCode == Keys.Right && pictureBox1.Right <= pictureBox2.Left && pictureBox1.Right <= pictureBox4.Left)
            {
                x = x + 20;

            }

            if (e.KeyCode == Keys.Right && pictureBox1.Right <= label17.Left)
            {

                label6.Visible = true;

            }
            if (e.KeyCode == Keys.Down && pictureBox1.Right >= label15.Left)
            {
                y = y + 20;

            }
            else
            {


            }
            if (e.KeyCode == Keys.Left && pictureBox1.Left >= pictureBox3.Right)
            {
                x = x - 20;
            }


            pictureBox1.Location = new Point(x, y);

        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(label24.Text) == 1)
            {
                label2WasClicked = true;
                int x4 = pictureBox4.Location.X;
                int y4 = pictureBox4.Location.Y;
                label13.Visible = true;
                x4 = 1102; y4 = 0;
                pictureBox4.Location = new Point(x4, y4);
                pictureBox4.Visible = false;
            }

            if (Convert.ToInt32(label24.Text) == 2)
            {



                label13.Visible = true;
                label19.Visible = true;
                label20.Visible = true;
                label21.Visible = true;
                label22.Visible = true;
                label23.Visible = true;

                int sayi = Convert.ToInt32(label13.Text);
                sayi += 10;
                label13.Text = Convert.ToString(sayi);

            }
        }



        private void label18_Click(object sender, EventArgs e)
        {
            label13.Visible = true;
            label18.Visible = false;
            if (Convert.ToInt32(label24.Text) == 1)
            {
                if (label2WasClicked)
                {
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = true;

                }
                if (label3WasClicked)
                {
                    pictureBox10.Visible = true;
                    pictureBox7.Visible = true;
                    pictureBox6.Visible = true;

                    label6.Visible = true;
                }
            }
            if (Convert.ToInt32(label24.Text) == 2)
            {
                if (label9WasClicked)
                {
                    if (label5WasClicked)
                    {
                        pictureBox11.Visible = true;
                        pictureBox5.Visible = true;

                    }
                }
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

            int x4 = pictureBox4.Location.X;
            int y4 = pictureBox4.Location.Y;

            label6.Visible = false;

            label13.Visible = false;
            x4 = 1102; y4 = 0;
            pictureBox4.Location = new Point(x4, y4);
            pictureBox4.Visible = false; label3WasClicked = true;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            pictureBox1.Focus();


        }

        private void label5_Click(object sender, EventArgs e)
        {

            label5WasClicked = true;
            if (Convert.ToInt32(label24.Text) == 2)
            {

                int x2 = pictureBox2.Location.X;
                int y2 = pictureBox2.Location.Y;
                label13.Visible = false;
                x2 = 1102; y2 = 0;
                int sayi = Convert.ToInt32(label13.Text);
                sayi += 10;
                label13.Text = Convert.ToString(sayi);
                pictureBox2.Location = new Point(x2, y2);
                pictureBox2.Visible = false;

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label18.Visible = true;
            int sayi2 = Convert.ToInt32(label24.Text);
            sayi2--;
            label24.Text = sayi2.ToString();
            if (Convert.ToInt32(label24.Text) == 1)
            {
                pictureBox11.Visible = false;
                pictureBox5.Visible = false;
                if (label2WasClicked)
                {

                }

                label13.Visible = false;

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            label18.Visible = true;
            label9WasClicked = true;
            int sayi2 = Convert.ToInt32(label24.Text);
            sayi2++;
            label24.Text = sayi2.ToString();

            if (Convert.ToInt32(label24.Text) == 2)
            {
                pictureBox6.Visible = false;

                label13.Visible = true;

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(label7.Text);
            a++;
            label7.Text = a.ToString();
            if (a == 2)
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
            }

            if (a == 15)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
            }

        }

       

        private void label10_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
            
                if (checkBox1.Checked && checkBox1.Text == label11.Text)
                {
                    int sayi = Convert.ToInt32(label13.Text);
                    sayi += 10;
                    label13.Text = Convert.ToString(sayi);
                }
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                if (Convert.ToInt32(label24.Text) == 1)
                {
                    label2WasClicked = true;
                    int x4 = pictureBox4.Location.X;
                    int y4 = pictureBox4.Location.Y;
                    label13.Visible = true;
                    x4 = 1102; y4 = 0;
                    pictureBox4.Location = new Point(x4, y4);
                    pictureBox4.Visible = false;
                }

                if (Convert.ToInt32(label24.Text) == 2)
                {

                    label13.Visible = true;
                    label19.Visible = true;
                    label20.Visible = true;
                    label21.Visible = true;
                    label22.Visible = true;
                    label23.Visible = true;

                    int sayi = Convert.ToInt32(label13.Text);
                    sayi += 10;
                    label13.Text = Convert.ToString(sayi);

                }
            }
            if (checkBox2.Checked == true)
            {
                if (checkBox2.Checked && checkBox2.Text == label11.Text)
                {
                    int sayi = Convert.ToInt32(label13.Text);
                    sayi += 10;
                    label13.Text = Convert.ToString(sayi);
                }
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                if (Convert.ToInt32(label24.Text) == 2)
                {


                    label13.Visible = true;
                    label19.Visible = true;
                    label20.Visible = true;
                    label21.Visible = true;
                    label22.Visible = true;
                    label23.Visible = true;

                    int sayi = Convert.ToInt32(label13.Text);
                    sayi += 10;
                    label13.Text = Convert.ToString(sayi);

                }
                int x4 = pictureBox4.Location.X;
                int y4 = pictureBox4.Location.Y;
                x4 = 1102; y4 = 0;
                pictureBox4.Location = new Point(x4, y4);
                pictureBox4.Visible = false; label3WasClicked = true;
            }
            if (checkBox3.Checked == true)
            {
                if (checkBox3.Checked && checkBox3.Text == label11.Text)
                {
                    int sayi = Convert.ToInt32(label13.Text);
                    sayi += 10;
                    label13.Text = Convert.ToString(sayi);
                }
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox4.Checked = false;
            }
            if (checkBox4.Checked == false)
            {
                checkBox4.Enabled = false;
            }
            if (checkBox4.Checked == true)
            {
                if (checkBox4.Checked && checkBox4.Text == label11.Text)
                {
                    int sayi = Convert.ToInt32(label13.Text);
                    sayi += 10;
                    label13.Text = Convert.ToString(sayi);
                }
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                label5WasClicked = true;
                if (Convert.ToInt32(label24.Text) == 2)
                {


                    int x2 = pictureBox2.Location.X;
                    int y2 = pictureBox2.Location.Y;
                    label13.Visible = false;
                    x2 = 1102; y2 = 0;
                    int sayi = Convert.ToInt32(label13.Text);
                    sayi += 10;
                    label13.Text = Convert.ToString(sayi);
                    pictureBox2.Location = new Point(x2, y2);
                    pictureBox2.Visible = false;

                }
            }
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            sayac++;
            label25.Text = sayac.ToString();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from soru3 order by id ASC", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (Convert.ToInt32(label25.Text) == 3)
            {

            }
            while (dr.Read())
            {
                checkBox1.Text = dr["a"].ToString();
                checkBox2.Text = dr["b"].ToString();
                checkBox3.Text = dr["c"].ToString();
                checkBox4.Text = dr["d"].ToString();
                label6.Text = dr["soru"].ToString();
                label11.Text = dr["dogru"].ToString();
            }

            conn.Close();
        }
    }
}
