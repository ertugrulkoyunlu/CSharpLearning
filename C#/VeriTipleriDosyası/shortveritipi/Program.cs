// See https://aka.ms/new-console-template for more information

namespace shortveritipi
{
class Program
    {
        static void Main(string []args)
        {
            // short değişkeni -32768 +32767 değer aralığını depolayabilmektedir.
            short birinciDegisken = -50;
            short ikinciDegisken = -25550;
            short ucuncuDegisken = -30000;
            short maxdeger = short.MaxValue;
            short mindeger = short.MinValue;
            Console.WriteLine(birinciDegisken);
            Console.WriteLine(ikinciDegisken);
            Console.WriteLine(ucuncuDegisken);
            Console.WriteLine(maxdeger);
            Console.WriteLine(mindeger);
            Console.ReadLine();

        }
    }
}