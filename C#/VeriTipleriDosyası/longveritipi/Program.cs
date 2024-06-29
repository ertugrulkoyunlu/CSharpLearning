namespace longveritipi
{
    class Program
    {
        static void Main(string[] args)
        {
            //long veri tipi-9,223,372,036,854,775,808 to -9,223,372,036,854,775,807 değer depolayabilmektedir
            //8 byte yer kaplar ve 19 basamak 10 üzeri 19 basamak yazabilir.tc kimlik numarası long tutabilir ama int tutamaz
            //çünkü int veri tipi 10 basamağa kadar tutabalir.
            long birinciDegisken = 575000;
            long ikinciDegisken = -923000;
            long ucuncuDegisken = 99999999999;
            long Maxdeger = long.MaxValue;
            long Mindeger = long.MinValue;
            int ondalikli_sayi = 5.69;// double
            Console.WriteLine(birinciDegisken);
            Console.WriteLine(ikinciDegisken);
            Console.WriteLine(ucuncuDegisken);
            Console.WriteLine(Maxdeger);
            Console.WriteLine(Mindeger);
            Console.WriteLine(ondalikli_sayi);
            Console.ReadLine();


        }
    }
}
