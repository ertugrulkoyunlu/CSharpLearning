int n;
string s;
s = "";

n = Convert.ToInt32(Console.ReadLine());

while(n > 0)
{
    n--;
    s = Console.ReadLine();
    if(s.Length<=10)
        Console.WriteLine(s);
    else
    {
        Console.WriteLine($"{s[0]}{s.Length-2}{s[s.Length-1]}");
    }
}