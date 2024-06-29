namespace For_For_each_While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i=0;i<=10;i++)
            {
                textBox1.Text = i.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[]isimler= {"Ali" , "Ayþe" , "Zeynep" };
            foreach(string s in isimler )
            { 
                MessageBox.Show(s);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(5);
            sayilar.Add(6);
            sayilar.Add(7);
            sayilar.Add(8);
            sayilar.Add(9);
            foreach(int i in sayilar)
            {
                MessageBox.Show(i.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0;
       
       while (i<10)
            {
                textBox2.Text +=" "+ i.ToString();
                i++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = 0;
            do
            {
                textBox3.Text +=" "+ a.ToString();
                a++;
            }
            while (a<10);
        }
    }
}