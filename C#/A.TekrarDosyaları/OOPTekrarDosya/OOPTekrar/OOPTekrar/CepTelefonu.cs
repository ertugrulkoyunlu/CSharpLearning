using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTekrar
{
    public class CepTelefonu:URUN
    {
        public string ozellikler{get;set;}
        public string Marka{get;set;}
        public override double kdvuygula()
        {
            return Fiyat * 1.05;
        }
        public CepTelefonu(string ad,double fiyat,string marka )
        {
            urunadi=ad;
            Fiyat =fiyat;
            Marka = marka;   
        }
    }
}
