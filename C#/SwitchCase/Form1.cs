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
                    MessageBox.Show("�smin bulunamad�");
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox2.Text);
            switch(i)
            {
                case 10:
                    MessageBox.Show("Daha �ocuksunuz");
                    break;
                case 18:
                    MessageBox.Show("Gen�siniz");
                    break;
                case 35:
                    MessageBox.Show("Orta ya�l�s�n�z");
                    break;
                case 50:
                    MessageBox.Show("Yeti�kinsiniz");
                    break;
                case 75:
                    MessageBox.Show("Ya�l�s�n�z");
                    break;
                default:
                    MessageBox.Show("Uygun ya� girmediniz");
                    break;

            }
        }
    }
}