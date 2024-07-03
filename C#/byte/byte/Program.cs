//Console.Write("Lutfen bir sayi girin");
//ConsoleColor renk = (ConsoleColor)Convert.ToInt16(Console.ReadLine());
//Console.BackgroundColor = renk;
//Console.Clear();
//Console.Read();
int[,] dizi = new int[2, 2];
dizi[0, 0] = 25;
dizi[0, 1] = 12;
dizi[1, 0] = 34;
dizi[1, 1] = 42;
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)

        Console.Write(" {0} ", dizi[i, j]);
    Console.WriteLine();


}
Console.Read();