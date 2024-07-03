//int[] sayilar = { 4, 1, 7, 84, -75, 14, 23, 51, -8, 9,24 };
//foreach (int i in sayilar)
//{
//    if (i > 10 && i<30 && i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}
int[] sayilar = new int[5];
for (int i = 0; i < 5; i++)
{
    Console.Write("Sayiyi girin: ");
    sayilar[i] = Convert.ToInt32(Console.ReadLine());

}
Array.Sort(sayilar);
Console.Write("en kucuk eleman:" + sayilar[0]);
Console.WriteLine("\neleman sayisi:"+sayilar.Length);
//foreach(int i in sayilar)
//{
//    Console.WriteLine(sayilar[4]);
//}
Console.Read();
