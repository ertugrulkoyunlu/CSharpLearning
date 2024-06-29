using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int sonuc;
            a = Convert.ToInt32(textBox1.Text);// (textbox1 de string olan yani metinsel olan bir degeri integera yani sayisal bir degere donustururmus. ){ToInt32==32 milyon + 32 milyon arasinda deger alir}
            b = Convert.ToInt32(textBox2.Text);// (textBox2 de string olan yani metinsel olan bir degeri integera yani sayisal bir degere donustururmus. ){ToInt32==32 milyon + 32 milyon arasinda deger alir}
            sonuc = a + b;
            label4.Text = Convert.ToString(sonuc);// (sonucu metinsel degere stringe cevirir.)[]
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox3.Text);
            double b = Convert.ToDouble(textBox4.Text);
            double sonuc;
            sonuc = a + b;
            label7.Text= Convert.ToString(sonuc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox5.Text);
            double b = Convert.ToDouble(textBox6.Text);
            double sonuc;
            sonuc = a - b;
            label9.Text= Convert.ToString(sonuc);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a=Convert.ToDouble(textBox7.Text);
            double b=Convert.ToDouble(textBox8.Text);
            double sonuc;
            sonuc=a*b;
            label13.Text= Convert.ToString(sonuc);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double a =Convert.ToDouble(textBox9.Text);
            double b =Convert.ToDouble(textBox10.Text);
            double sonuc;
            sonuc=a/b;
            label17.Text=Convert.ToString(sonuc);
        }
    }
}
