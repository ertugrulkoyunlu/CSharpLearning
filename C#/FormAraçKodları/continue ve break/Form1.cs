namespace continue_ve_break
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=0;i<10;i++)
            {
                if (i == 3)  continue;
                
                
                    
                    textBox1.Text += i.ToString();
                
                
                

            }
        }
    }
}