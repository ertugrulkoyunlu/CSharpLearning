using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties__Özellikler__Get_Set
{
     class Sınıf
    {
        string adim;
        public Sınıf(string ad)
        {
            adim = ad;
            
        }
        public string  Ad
        {
            get { return adim; }    
            
        set {
                if (value == "Ema") System.Windows.Forms.MessageBox.Show("Ema yazdınız");
                {
                
                }
            }
        }
            
    }
}
