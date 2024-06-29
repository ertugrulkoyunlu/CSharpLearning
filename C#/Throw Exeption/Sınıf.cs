using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Throw_Exeption
{
     class Sınıf
    {
        static Exception exception=new Exception("Bu metni boş bir stringe eşitleyebilirsiniz");
        public static void metinKontrolü(string metin)
        {
            if (metin == "") throw  exception;    
        }
    }
}
