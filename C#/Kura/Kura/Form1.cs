using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kura
{
    public partial class Form1 : Form
    {
        List<Takim> takimlar;
        List<ListBox> torbalar = new List<ListBox>();
        List<ListBox> gruplar = new List<ListBox>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Takim yenitakim = null;
            takimlar = new List<Takim>();   
            
            yenitakim = new Takim("Bayern Munih", "Almanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Fc Barcelona", "Ispanya");
            takimlar.Add(yenitakim);
            
            yenitakim = new Takim("Chelsea", "Ingiltere");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Real Madrid", "Ispanya");
            takimlar.Add(yenitakim);
            
            yenitakim = new Takim("Manchester United", "Ingiltere");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Arsenal", "Ingiltere");
            takimlar.Add(yenitakim);

            yenitakim = new Takim(" Porto", "Portekiz");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Atletico Madrid ", "Ispanya");
            takimlar.Add(yenitakim);

            yenitakim = new Takim("Shaktar Donetisk", "Ukrayna");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Milan", "Italya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Schalke 04", "Almanya");
            takimlar.Add(yenitakim);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            List<int> secilentakimlar = new List<int>();
            for (int j = 0; j < 4; j++)
            {
                secilentakimlar.Clear();
                for (int i = 0; i < 8; i++)
                {
                    int secilentakim = rnd.Next(0, takimlar.Count / 4);

                    if (secilentakimlar.Contains(secilentakim))
                    {
                        i--;
                    }
                    else
                    {
                        secilentakimlar.Add(secilentakim);
                    }
                }
                bool ayniulkedentakimvar = false;
                for (int k = 0; k < 8; k++)
                {
                    ayniulkedentakimvar = Ayniulkedentakimvarmi(gruplar[k], torbalar[j].Items[secilentakimlar[k]] as Takim);
                    if (ayniulkedentakimvar)
                        break;
                }
                if (!ayniulkedentakimvar)
                {
                    listBox1.Items.Add(torbalar[j].Items[secilentakimlar[0]] as Takim);
                    listBox2.Items.Add(torbalar[j].Items[secilentakimlar[1]] as Takim);
                    listBox3.Items.Add(torbalar[j].Items[secilentakimlar[2]] as Takim);
                    listBox4.Items.Add(torbalar[j].Items[secilentakimlar[3]] as Takim);
                    listBox5.Items.Add(torbalar[j].Items[secilentakimlar[4]] as Takim);
                    listBox6.Items.Add(torbalar[j].Items[secilentakimlar[5]] as Takim);
                    listBox7.Items.Add(torbalar[j].Items[secilentakimlar[6]] as Takim);
                }
                else
                {
                    j--;
                }
            }
        }
        private bool Ayniulkedentakimvarmi(ListBox grup, Takim takim)
        {
            bool durum = false;
            for (int i = 0; i < grup.Items.Count; i++)
            {
                Takim gruptakim = grup.Items[i] as Takim;
                if (gruptakim.TeamCountry == takim.TeamCountry)
                {
                    durum = true;
                    break;
                }
            }
            return durum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            List<int> secilentakimlar = new List<int>();
            for (int i = 0; i < takimlar.Count; i++)
            {
                int secilentakim = rnd.Next(0,takimlar.Count);
                if (secilentakimlar.Contains(secilentakim))
                {
                    i--;
                }
                else
                {
                    secilentakimlar.Add(secilentakim);
                }
            }
            for (int i = 0; i < secilentakimlar.Count;i++)
            {
                if (i < 8)
                {
                    listBox1.Items.Add(takimlar[secilentakimlar[i]]);
                }
                else if (i < 16)
                {
                    listBox2.Items.Add(takimlar[secilentakimlar[i]]);
                }
                else if (i < 24)
                {
                    listBox3.Items.Add(takimlar[secilentakimlar[i]]);
                }
                else
                {
                    listBox4.Items.Add(takimlar[secilentakimlar[i]]);
                }

            }
            torbalar.Add(listBox1);
            torbalar.Add(listBox2);
            torbalar.Add(listBox3);
            torbalar.Add(listBox4);
            gruplar.Add(listBox5);
            gruplar.Add(listBox6);
            gruplar.Add(listBox7);
            gruplar.Add(listBox8);
            gruplar.Add(listBox9);
            gruplar.Add(listBox10);
            gruplar.Add(listBox11);
            gruplar.Add(listBox12);
        }
    }
}
