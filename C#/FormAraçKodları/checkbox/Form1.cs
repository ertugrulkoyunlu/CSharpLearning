namespace checkbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox2.Text);
            int y = Convert.ToInt32(textBox3.Text);
            if (x < y)
            {
                MessageBox.Show("say�1 say�2` den k���kt�r:");
            }
            else if (x == y)
            {
                MessageBox.Show("say�1 say�2`  ye e�ittir:");
            }

            else 
            {
                MessageBox.Show("say�1 say�2` den b�y�kt�r:");
            }

        
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "elma" && checkBox1.Checked)
            {
                MessageBox.Show("Elma bey hosgeldiniz");
                else
                { 
                MessageBox.Show("tik at�p tekrar deneyiniz");
                }
            }
            else
            {
                MessageBox.Show("Yanl�� isim girdiniz");
            }
        }
    }
}