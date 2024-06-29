namespace f11
{
    public partial class Form1 : Form
    {
        int v1, v2, final;
        double basari;
        string[] satir;

        public Form1()
        {
            InitializeComponent();
        }


        private void basaribtn_Click(object sender, EventArgs e)
        {
            StreamWriter dosya = File.CreateText("deneme.txt");
            v1 = Convert.ToInt16(textBox4.Text);
            v2 = Convert.ToInt16(textBox5.Text);
            final = Convert.ToInt16(textBox6.Text);
            basari = (v1 + v2) / 2 * 0.4 + final * 0.6;
            textBox7.Text = Convert.ToString(basari).ToString();
            dosya.WriteLine(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text + " " + textBox5.Text
                + " " + textBox6.Text + " " + textBox7.Text);
            Console.ReadLine();
            dosya.Close();
        }



        private void çýk_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ilaveet_Click(object sender, EventArgs e)
        {
            StreamWriter dosya = File.AppendText("deneme.txt");
            v1 = Convert.ToInt16(textBox4.Text);
            v2 = Convert.ToInt16(textBox5.Text);
            final = Convert.ToInt16(textBox6.Text);
            basari = (v1 + v2) / 2 * 0.4 + final * 0.6;

            textBox7.Text = Convert.ToString(basari).ToString();

            dosya.WriteLine(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text + " " + textBox5.Text + " "
                + textBox6.Text + " " + textBox7.Text);
            Console.ReadLine();
            dosya.Close();
        }
        private void Oku_Click(object sender, EventArgs e)
        {
            string satir;
            StreamReader dosya = File.OpenText("deneme.txt");
            satir = dosya.ReadLine();
            while (satir != null)
            {
                string[] sdizi = satir.Split(' ');
                textBox1.Text = sdizi[0];
                textBox2.Text = sdizi[1];
                textBox3.Text = sdizi[2];
                textBox4.Text = sdizi[3];
                textBox5.Text = sdizi[4];
                textBox6.Text = sdizi[5];
                textBox7.Text = sdizi[6];
                satir = dosya.ReadLine();
            }
        }

    }
}