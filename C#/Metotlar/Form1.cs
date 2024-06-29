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
            mesaj("Elma", "baþlýk");
        }
        void mesaj(string mesaj, string baþlýk)
        {
            MessageBox.Show(mesaj, baþlýk);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mesaj("Armut", "baþlýk");
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
            MessageBox.Show(SayýGöster().ToString());
        }
        int SayýGöster()
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