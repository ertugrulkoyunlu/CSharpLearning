namespace combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);    
                }/*text boxa yaz�lan ismi listboxa ekler*/

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            /*listboxda se�ilen kutuyu siler*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
            /*textboxa yaz�lan yeri comboboxa ekler*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(textBox1.Text);
            /* textboxa yaz�lan yeri comboboxa ekler */
        }
    }
}