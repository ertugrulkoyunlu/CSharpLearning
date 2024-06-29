using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4CokBicimlilik
{
    public class sepet
    {
        private List<URUN> urunler = new List<URUN>();
        public double toplamtutar()
        {
            double toplamfiyat = 0;
            foreach (URUN item in urunler)
            {
                toplamfiyat += item.kdvuygula();
            }
            return toplamfiyat;
        }
        public void Urunekle(URUN yeniurun)
        {
            urunler.Add(yeniurun);
        }
    }
}
