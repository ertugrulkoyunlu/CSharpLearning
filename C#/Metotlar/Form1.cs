namespace Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mesaj("Elma", "ba�l�k");
        }
        void mesaj(string mesaj, string ba�l�k)
        {
            MessageBox.Show(mesaj, ba�l�k);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mesaj("Armut", "ba�l�k");
        }

        private void button3_Click(object sender, EventArgs e)
        {
        MessageBox.Show(Metodum("Elma"));
        }
        string Metodum(string ad)
        {
            return ad;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Baskent());   
        }
        string Baskent()
        {
            return "Ankara";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Say�G�ster().ToString());
        }
        int Say�G�ster()
        {
            return 118;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dogrumu().ToString());
        }
        bool dogrumu()
        {
            return false;
        }
    }
}