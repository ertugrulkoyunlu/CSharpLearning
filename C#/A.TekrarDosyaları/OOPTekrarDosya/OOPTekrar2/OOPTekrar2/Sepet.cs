using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTekrar2
{
    public class Sepet
    {
        private List<URUNLER> urunler = new List<URUNLER>();
        public double toplamtutar()
        {
            double toplamfiyat = 0;
            foreach (URUNLER item in urunler)
            {
                toplamfiyat += item.kdvuygula();
            }
            return toplamfiyat;
        }
        public void Urunekle(URUNLER yeniurun)
        {
            urunler.Add(yeniurun);
        }
    }
}
