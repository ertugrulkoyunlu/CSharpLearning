//string[] sehirler={"Adana","Istanbul","Izmir","Bursa","Erzurum","Sanliurfa"};
//foreach(string i in sehirler)
//{
//Console.WriteLine(i);

//}
//Console.Read();
//int[] sayilar = { 1, 4, 8, 52, 41, 75, 126, 85, 24 };
//foreach (int i in sayilar)
//{
//    Console.WriteLine(i);
//}
//Console.Read();
//int[] sayilar={1,4,8,9,6};
//int toplam=0;
//foreach(int i in sayilar)
//{
//    toplam=toplam+i;
//    Console.WriteLine(toplam);
//}
//int[] sayilar={12,35,23,16,19,15,42};
//foreach(int i in sayilar)
//{
//    if(i%2==0)
//    {
//        Console.WriteLine(i);
//    }
//}
//Console.Read();
int[]sayilar={1,2,3,4,5,6};
int sonuc=1;
foreach(int i in sayilar)
{
sonuc=sonuc*i;
}
Console.WriteLine("6 sayisin faktoriyeli:"+sonuc);
Console.Read();