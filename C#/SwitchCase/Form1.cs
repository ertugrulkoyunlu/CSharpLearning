namespace SwitchCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (textBox1.Text)
            {
                case "Elma":
                    MessageBox.Show("Merheba Elma bey");
                    break;
                case "Armut":
                    MessageBox.Show("Merhaba Armut bey");
                    break;
                default:
                    MessageBox.Show("Ýsmin bulunamadý");
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox2.Text);
            switch(i)
            {
                case 10:
                    MessageBox.Show("Daha çocuksunuz");
                    break;
                case 18:
                    MessageBox.Show("Gençsiniz");
                    break;
                case 35:
                    MessageBox.Show("Orta yaþlýsýnýz");
                    break;
                case 50:
                    MessageBox.Show("Yetiþkinsiniz");
                    break;
                case 75:
                    MessageBox.Show("Yaþlýsýnýz");
                    break;
                default:
                    MessageBox.Show("Uygun yaþ girmediniz");
                    break;

            }
        }
    }
}