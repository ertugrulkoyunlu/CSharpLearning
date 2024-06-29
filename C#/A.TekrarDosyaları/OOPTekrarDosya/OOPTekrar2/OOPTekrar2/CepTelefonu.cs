using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOPTekrar2
{
    public class CepTelefonu : URUNLER
    {
        public string Ozellikler { get; set; }
        public string Marka { get; set; }
        public override double kdvuygula()
        {
            return Fiyat +Fiyat *  20/100;
        }
        public CepTelefonu(string ad, double fiyat, string marka)
        {
            Urunadi = ad;
            Fiyat = fiyat;
            Marka = marka;

        }
    }
}
