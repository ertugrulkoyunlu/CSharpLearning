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
                MessageBox.Show("sayý1 sayý2` den küçüktür:");
            }
            else if (x == y)
            {
                MessageBox.Show("sayý1 sayý2`  ye eþittir:");
            }

            else 
            {
                MessageBox.Show("sayý1 sayý2` den büyüktür:");
            }

        
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "elma" && checkBox1.Checked)
            {
                MessageBox.Show("Elma bey hosgeldiniz");
                else
                { 
                MessageBox.Show("tik atýp tekrar deneyiniz");
                }
            }
            else
            {
                MessageBox.Show("Yanlýþ isim girdiniz");
            }
        }
    }
}