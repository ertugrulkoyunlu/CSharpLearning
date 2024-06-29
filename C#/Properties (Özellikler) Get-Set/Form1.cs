using System.Windows.Forms;
namespace Properties__Özellikler__Get_Set
{
    public partial class Form1 : Form
    {
         public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sınıf bs = new Sınıf ("Elma");
            bs.Ad = "Ema";
            MessageBox.Show(bs.Ad);
        }
   }
}