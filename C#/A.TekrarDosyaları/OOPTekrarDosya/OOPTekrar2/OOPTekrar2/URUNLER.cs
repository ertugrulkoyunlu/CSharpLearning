using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTekrar2
{
    public class URUNLER
    {
        public string Urunadi { get; set; }
        public double Fiyat { get; set; }
        public virtual double kdvuygula()
        {
            return Fiyat * 1.08;
        }
        public URUNLER()
        {
        
        }
        public URUNLER(string ad, double fiyat)
        {
            Urunadi = ad;
            Fiyat = fiyat;
        }
    }
}
