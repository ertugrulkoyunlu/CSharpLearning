string[] isim = new string[3];
int[] s1 = new int[3];
int[] s2 = new int[3];
int[] ort = new int[3];
for (int i = 0; i < 3; i++)
{
    Console.Clear();
    Console.Write((i + 1) + ". Ogrencinin adi");
    isim[i] = Console.ReadLine();

    Console.Write(i + 1 + ". nin  1. sinavi");
    s1[i] = Convert.ToInt32(Console.ReadLine());

    Console.Write(i + 1 + ". nin 2. sinavi ");
    s2[i] = Convert.ToInt32(Console.ReadLine());

    ort[i] = (s1[i] + s2[i]) / 2;
}
Console.Write("Ogrenci Sinav1 Sinav2 Ortalama");
Console.WriteLine();
for (int i = 0; i < 3; i++)
{
Console.WriteLine(" "+isim[i]+"    "+s1[i]+"     "+s2[i]+"      "+ort[i]);
}
Console.Read();