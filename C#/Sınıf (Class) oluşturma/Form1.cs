using System.Windows.Forms;
using Mynamespace;
namespace Sınıf__Class__oluşturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sınıfım snf = new Sınıfım("Muhammed");
            snf.ad();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sınıfım.MesajGöster("Elma");
        }
    }
}