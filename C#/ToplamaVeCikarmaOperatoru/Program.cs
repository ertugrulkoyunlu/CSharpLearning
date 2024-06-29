namespace ToplamaVeCikarmaOperatoru
{
    class program
    {
        static void Main(string[]args)
        {
            //toplama operatoru +
            //cıkarma operatoru -

            double sayi1;
            double sayi2;
            Console.WriteLine("bir sayi giriniz:");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ikinci bir sayi giriniz");
            sayi2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("girdiginiz sayilar sunlardir:\n" + sayi1);
            Console.WriteLine(sayi2);

           

            
            
            
            double topla = sayi1 + sayi2;
            double cıkar =  sayi1 - sayi2;
            double carpma = sayi1 * sayi2;
            double bolme = sayi1 / sayi2;
            Console.Write("Sayi1 ile sayi2 ikinin toplamı sudur:");
            Console.WriteLine(topla);
            Console.Write("sayi1 ile sayi2 nin farkı sudur:");
            Console.WriteLine(cıkar);
            Console.Write("sayi1 ile sayi2 nin carpımı sudur:");
            Console.WriteLine(carpma);
            Console.Write("sayi1 ile sayi2 nin bolumu sudur:");
            Console.WriteLine(bolme);
            Console.ReadLine();
        }
    }
}