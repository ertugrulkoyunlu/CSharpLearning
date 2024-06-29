using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTekrar
{
    public class Tekstil : URUN
    {
        public string Kumasturu { get; set; }
        public int Beden { get; set; }
        public string Ureticifirma { get; set; }
        public Tekstil(string ad, double fiyat, string kumasturu, int beden)
        {
            urunadi = ad;
            Fiyat = fiyat;
            Kumasturu = kumasturu;
            Beden = beden;
        }
    }
}
