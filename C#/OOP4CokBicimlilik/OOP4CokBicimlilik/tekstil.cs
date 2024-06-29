using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4CokBicimlilik
{
    public class tekstil : URUN
    {
        public string Kumasturu { get; set; }
        public int Beden { get; set; }
        public string Ureticifirma { get; set; }
        public tekstil(string ad, double fiyat, string kumasturu, int beden)
        {
            urunadi = ad;
            Fiyat = fiyat;
            Kumasturu = kumasturu;
            Beden = beden;
        }
    }
}
