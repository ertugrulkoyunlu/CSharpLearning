﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
namespace SystemNetOrnekler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Bilgisayar:" + Dns.GetHostName();
            foreach (IPAddress adres in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                textBox2.Text = "Ip adresi:" + adres;
            }
        }
    }
}
