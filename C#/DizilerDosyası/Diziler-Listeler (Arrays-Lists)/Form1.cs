namespace Diziler_Listeler__Arrays_Lists_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Ýsimler = { "Ali", "Mehmet", "Rýza", "Ayþe" };
            MessageBox.Show(Ýsimler[3]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] Yerler = new string [ 5 ] ;
            Yerler[0] = "Erzurum";
            Yerler[1] = "Adana";
            Yerler[2] = "Ýstanbul";
            Yerler[3] = "Ýzmir";
            Yerler[4] = "Kayseri";
            MessageBox.Show(Yerler[0]);
            MessageBox.Show(Yerler[1]);
            MessageBox.Show(Yerler[2]);
            MessageBox.Show(Yerler[3]);
            MessageBox.Show(Yerler[4]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 0,1, 2, 3, 4, 5 };
            MessageBox.Show(sayilar[5].ToString());
            MessageBox.Show(sayilar[4].ToString());
            MessageBox.Show(sayilar[3].ToString());
            MessageBox.Show(sayilar[2].ToString());
            MessageBox.Show(sayilar[1].ToString());
            MessageBox.Show(sayilar[0].ToString());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> Ýsimler = new List<string>();
            Ýsimler.Add("Ali");
            Ýsimler.Add("Veli");
            Ýsimler.Add("Mehmet");
            MessageBox.Show(Ýsimler[1]);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<int> Sayilar = new List<int>();
            Sayilar.Add(32);
            Sayilar.Add(42);
            Sayilar.Add(256);
            Sayilar.Add(3599);
            Sayilar.Add(9321123);
            MessageBox.Show(Sayilar[0].ToString());
            MessageBox.Show(Sayilar[1].ToString());
            MessageBox.Show(Sayilar[2].ToString());
            MessageBox.Show(Sayilar[3].ToString());
            MessageBox.Show(Sayilar[4].ToString());
        }
    }
}