// See https://aka.ms/new-console-template for more information
namespace intveritipi
{
    class Program
    { 
        static void Main(string[]args)
        {
            //int veri tipi -2 milyon +2 milyon arasında(-2147483648 - 2147483647) ve 10 basamaklı sayılara kadar yazabilir
            //8 bit =1 byte
            //1024 byte=1mb
            //1024 mb=1gb
            //1024 gb=1tb
            //1024 tb=1pb
            int birinciDegisken = 15000000;
            int ikinciDegisken = -50000000;
            int Maxdeger = int.MaxValue;
            int Mindeger = int.MinValue;
            Console.WriteLine(birinciDegisken);
            Console.WriteLine(ikinciDegisken);
            Console.WriteLine(Maxdeger);
            Console.WriteLine(Mindeger);
            Console.ReadLine();
        }
    }
}
