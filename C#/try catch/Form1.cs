namespace try_catch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] adlar = new string[2];
                string isim = adlar[5];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Kod satýrýn bitti..");
            }
        }
    }
}