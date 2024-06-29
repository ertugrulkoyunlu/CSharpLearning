namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string metin;
            int sayi;
            Console.WriteLine("Bir metin ve sayi giriniz:");
            metin = Console.ReadLine();
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("girilen metin:" + metin);
            Console.WriteLine("girilen sayi: " + sayi);
            Console.ReadLine();
        }
    }
}
