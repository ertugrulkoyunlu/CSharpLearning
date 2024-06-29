using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTekrar2
{
    public class Tekstil : URUNLER
    {
        public string Kumasturu { get; set; }
        public double Beden { get; set; }
        public string Ureticifirma { get; set; }
        public Tekstil(string ad, double fiyat, double beden, string ureticifirma)
        { 
            Urunadi=ad;
            Fiyat=fiyat;
            Beden = beden;
            Ureticifirma = ureticifirma;
        }
    }
}
