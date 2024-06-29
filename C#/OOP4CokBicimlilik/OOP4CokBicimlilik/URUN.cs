using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4CokBicimlilik
{
    public class URUN
    {
        public string urunadi { get; set; }
        public double Fiyat { get; set; }
        public virtual double kdvuygula()
        {
            return Fiyat * 1.08;
        }
        public URUN()
        {
        
        }
        public URUN (string ad,double fiyat)
        {
            urunadi=ad;
            Fiyat = fiyat;
        }
    }
}
