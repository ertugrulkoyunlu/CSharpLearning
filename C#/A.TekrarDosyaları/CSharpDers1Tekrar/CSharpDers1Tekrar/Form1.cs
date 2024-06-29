using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpDers1Tekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private bool asagiDogru = true;
        private bool sagaDogru = true;



        private void timer1_Tick(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(label2.Text);

            a++;

            label2.Text = Convert.ToString(a);
            int genislik = pictureBox1.Width;
            int uzunluk = pictureBox1.Height;
            int sagbitis = label3.Left;
            int altbitis = label5.Top;
            int ustbitis = label6.Top;
            int solbitis = label7.Left;

            Console.WriteLine("altbitis"+altbitis + " " + ustbitis + " " + solbitis + " " +sagbitis);
            Console.WriteLine("uzunluk" +uzunluk + " " + genislik );
            Console.WriteLine("kordinatlar" + pictureBox1.Top + " " + pictureBox1.Left);
            if (asagiDogru)
            {
                // 182 + 439 =621 altbitis 619
                if (uzunluk + pictureBox1.Top <= altbitis)
                {
                    pictureBox1.Top += 10;
                }
                else
                {
                    asagiDogru = false;
                }
            }
            
            else
            { //182+ 439=621 altbitis 619 
              //182 +429=611 
                if (uzunluk + pictureBox1.Top >= ustbitis)//
                {
                    pictureBox1.Top -= 10;
                }
                else
                {
                    asagiDogru = true;
                }

            }


            if (sagaDogru)
            {

                if (genislik + pictureBox1.Left <= sagbitis)
                {
                    pictureBox1.Left += 25;
                }

                else
                {
                    sagaDogru = false;
                }
            }

            else
            {
                if (genislik + pictureBox1.Left >= solbitis)
                {
                    pictureBox1.Left -= 25;
                }
                else
                {
                    sagaDogru=true;
                }

            }
            /*
                        i++;
                        if (solaDogru2)
                        {
                            if (asagiDogru3)
                            {
                                if (asagiDogru)
                                {
                                    if (uzunluk + pictureBox1.Top <= altbitis)
                                    {
                                        pictureBox1.Top += 10;
                                    }
                                    else
                                    {
                                        asagiDogru = false;
                                    }
                                }

                                else
                                {
                                    if (uzunluk + pictureBox1.Top >= altbitis)
                                    {
                                        pictureBox1.Top -= 10;
                                    }
                                    else if (uzunluk + pictureBox1.Top != altbitis)
                                    {
                                        pictureBox1.Top -= 10;
                                    }

                                }


                                if (sagaDogru)
                                {

                                    if (genislik + pictureBox1.Left <= sagyanbitis)
                                    {
                                        pictureBox1.Left += 25;
                                    }

                                    else
                                    {
                                        sagaDogru = false;
                                    }
                                }

                                else
                                {
                                    if (genislik + pictureBox1.Left >= sagyanbitis)
                                    {
                                        pictureBox1.Left -= 25;
                                    }
                                    else if (uzunluk + pictureBox1.Top != altbitis)
                                    {
                                        pictureBox1.Left -= 25;
                                    }
                                    asagiDogru3 = false;
                                }

                            }
                            else
                            {
                                if (solaDogru)
                                {
                                    if (uzunluk + pictureBox1.Top >= solbitis)
                                    {
                                        pictureBox1.Left -= 25;
                                    }
                                    else
                                    {
                                        solaDogru = false;
                                    }

                                }
                                else
                                {
                                    if (uzunluk + pictureBox1.Top <= altbitis)
                                    {
                                        pictureBox1.Left -= 25;
                                    }
                                    else if (uzunluk + pictureBox1.Top != altbitis)
                                    {
                                        pictureBox1.Left -= 25;
                                    }
                                    asagiDogru3 = false;
                                }

                                if (yukariDogru)
                                {
                                    if (pictureBox1.Top >= ustbitis)
                                    {
                                        pictureBox1.Top -= 10;
                                    }
                                    else
                                    {
                                        yukariDogru = false;
                                    }

                                }
                                else
                                {
                                    if (uzunluk + pictureBox1.Top != ustbitis)
                                    {
                                        pictureBox1.Top += 10;

                                    }
                                    solaDogru2 = false;
                                }
                            }

                        }
                        else
                        {
                            if (asagiDogru2)
                            {
                                if (pictureBox1.Top >= ustbitis)
                                {
                                    pictureBox1.Top += 10;
                                }
                            }
                            if (solaDogru3)
                            {
                                if (pictureBox1.Left >= solbitis)
                                {
                                    pictureBox1.Left -= 25;
                                }
                                else
                                {
                                    solaDogru3 = false;
                                }

                            }
                            else
                            {
                                if (pictureBox1.Left <= solbitis)
                                {
                                    pictureBox1.Left += 25;
                                }
                                else if (uzunluk + pictureBox1.Top != solbitis)
                                {
                                    pictureBox1.Left += 25;
                                }
                            }
                        }
                        Console.WriteLine("kordinatlar" + pictureBox1.Top + " " + pictureBox1.Left);
            */
        }
    }
}






