using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTekrar2
{
    public class Ekmek : URUNLER
    {
        public string Ekmekturu { get; set; }
        public int Gramaj { get; set; }
        public override double kdvuygula()
        {
            return Fiyat + Fiyat *  1/100;
        }
        public Ekmek(string ad, double fiyat, string ekmekturu, int gramaj)
        {
            Fiyat = fiyat;
            Urunadi = ad;
            Ekmekturu = ekmekturu;
            Gramaj = gramaj;
        }
    }
}
