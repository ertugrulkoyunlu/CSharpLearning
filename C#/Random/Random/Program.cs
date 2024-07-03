//Random rastgele=new Random();
//int a;
//a=rastgele.Next(0, 10);
//Console.Write(a);
string[] sehirler = { "Adana", "Istanbul", "Kayseri", "Bursa", "Kahramanmaras", "Konya", "Elazig", "Malatya" };
Random rastgele = new Random();
int a;
a=rastgele.Next(0,sehirler.Length);
Console.WriteLine(sehirler[a]);
