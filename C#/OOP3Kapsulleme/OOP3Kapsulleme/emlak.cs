using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3Kapsulleme
{
    class emlak
    {
        private string semt;
        private int odasayisi;
        private int katno;
        private int alan;

        public string Semt { get => semt; set => semt = value.ToUpper(); }
        public int Odasayisi { get => odasayisi; set => odasayisi = Math.Abs(value); }
        public int Katno { get => katno; set => katno = Math.Abs(value); }
        public int Alan { get => alan; set => alan = Math.Abs(value); }
    }
}
