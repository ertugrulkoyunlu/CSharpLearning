using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance__Kalıtım_
{
     class sınıf
    {
        public string ad = "elma";
        public int yas = 32;
        public void MesajGoster(string mesaj)
        {
            System.Windows.Forms.MessageBox.Show(mesaj);
        }
    }
class ikincisınıf : sınıf
    {
        public string sacRengi = "Siyah";
        public void OzelMesajKutusu()
        {
            System.Windows.Forms.MessageBox.Show(base.yas.ToString());
        }
        public void AdGoster()
        {
            base.MesajGoster(base.ad); 
        }
 class ücüncüsinif : ikincisınıf
        {
            public void SacRengiGoster()
            {
                System.Windows.Forms.MessageBox.Show(base.sacRengi);
            }
        }
    }
}
