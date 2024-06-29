namespace Matematiksel_Operatörler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /*
            +:toplama -:ckarma *:carpma /:bolme %:mod bolme --:bir azaltma:++ bir artırma =: atama
            >:büyük <:küçük >=:büyük eşit <=:küçük eşit  ==eşit !=farklı
            &&:ve (and)
            ||:veya
            !:değil
             */
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sonuç = sayi1 + sayi2;
            textBox3.Text = sonuç.ToString(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox6.Text);
            int sayi2 = Convert.ToInt32(textBox5.Text);
            int sonuç = sayi1 - sayi2;
            textBox4.Text =sonuç.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox9.Text);
            int sayi2 = Convert.ToInt32(textBox8.Text);
            int sonuç = sayi1 * sayi2;
            textBox7.Text=sonuç.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox12.Text);
            int sayi2 = Convert.ToInt32(textBox11.Text);
            int sonuç = sayi1 / sayi2;
            textBox10.Text = sonuç.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox15.Text);
            sayi1 /=3;
            textBox13.Text = sayi1.ToString();
        }
    }
}