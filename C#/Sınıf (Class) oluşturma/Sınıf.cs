using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Mynamespace

{
    
    class Sınıfım
    {
        enum Adlar
            {
            Ertuğrul,
            Sancar,
            Mehmet,
        }
        Adlar benimAdım=Adlar.Ertuğrul;
        Adlar abiminAdı=Adlar.Sancar;
        Adlar babamınAdı=Adlar.Mehmet; 


        string Ad;
        public Sınıfım(string ad)
        {
            Ad = ad;
        }
        public string ad()
        {
            return Ad;  
        }
        public static void MesajGöster(string mesaj)
        {
            MessageBox.Show(mesaj);
        }
        public static void MesajGöster(int mesaj)
        {
            MessageBox.Show(mesaj.ToString());
        }

        public Sınıfım(int yaş)
        {

        }
    }
}

