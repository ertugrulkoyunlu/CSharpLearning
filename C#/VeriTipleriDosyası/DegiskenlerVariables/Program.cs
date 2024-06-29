using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegiskenlerVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string i = "Mehmet ";                                            // yazıcagımız degiskenin turu 
            string b = " bir";
            string c = " bilgisayar";
            string d = " muhendisidir.";
            int y = 40;
            string e = " yas";
            string f = "indadir.";
            string g = "inda";
            Console.WriteLine(i + b + c + d);
            Console.WriteLine(i + " en cok c# yapamyi sever.");
            Console.WriteLine(i + y + e +f );
            Console.WriteLine(i + "ama " + y + e + g + " gibi hissetmiyordur.");
            Console.ReadLine();

        }
    }
}
