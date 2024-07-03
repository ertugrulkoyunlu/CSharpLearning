// See https://ak+a.ms/new-console-template for more information
//int [] sayilar= {10,45,21,35,64,75,81,26};
//Console.Write(sayilar[7]);
//string [] isimler={"ali","ahmet","ayse","emel","baran","akin"};
//Console.Write(isimler[3]);
//string[] sehirler = new string[3];
//for (int i= 0; i < 3; i++)
//{
//    Console.Write("Sehir");
//    sehirler[i] = Console.ReadLine();
//}
//for(int i=0;i<3;i++)
//{
//    Console.WriteLine(sehirler[i]);    

//}
//Console.Read();
int[] sayilar = new int[5];
for (int i = 0; i < 5; i++)
{
    Console.Write((i + 1).ToString() + ".Sayiyi girin");
    sayilar[i] = Convert.ToInt32(Console.ReadLine());
}
int enbuyuk;
enbuyuk = sayilar[0];
for (int i = 1; i < 5; i++)
{
    if (enbuyuk > sayilar[i])
    {
        enbuyuk = sayilar[i];
    }

}
Console.Write(enbuyuk);
Console.ReadLine();