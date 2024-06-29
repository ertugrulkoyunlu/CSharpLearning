namespace Throw_Exeption
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
                Sýnýf.metinKontrolü("");
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}