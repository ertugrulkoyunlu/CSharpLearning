namespace patates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pb.Image = Properties.Resources.dog;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pb.Image = Properties.Resources.cat;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pb.Image = Properties.Resources.duck;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pb.Image = Properties.Resources.monkey;
        }
    }
}