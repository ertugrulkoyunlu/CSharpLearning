using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4CokBicimlilik
{
    public class ekmek : URUN
    {
        public string Ekmekturu { get; set; }
        public int Gramaj { get; set; }
        
        public override double kdvuygula()
        {
            return Fiyat*1.01;
        }
        public ekmek(string ad, double fiyat, string ekmekturu, int gramaj)
        {
            urunadi = ad;
            Fiyat = fiyat;
            Ekmekturu = ekmekturu;
            Gramaj = gramaj;
        }
    }
}
