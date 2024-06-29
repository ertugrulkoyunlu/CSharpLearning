namespace floatveritipi
{
    class Program
    {
        static void Main(string []args)
        {
            //float ondalıklı sayı 10.1 7-8 arasında basamak arasındakı ondalıklı sayıları tutar 10.2323293-10.23232328
            //4byte
            float ondalikli_sayi1=35.32f;
            float ondalikli_sayi2 = 12.33333790332323f;
            float MaximumDeger = float.MaxValue;
            float MinDeger = float.MinValue;
            Console.WriteLine(ondalikli_sayi1);
            Console.WriteLine(ondalikli_sayi2);
            Console.WriteLine(MaximumDeger);
            Console.WriteLine(MinDeger);
            Console.ReadLine();
        }
    }
}