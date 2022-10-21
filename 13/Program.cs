int Find3Int(int a)
{
    while (a / 1000 != 0)
        a /= 10;
    return a % 10;
}

Console.WriteLine("Введите число: ");

int N = Convert.ToInt32(Console.ReadLine());

if (N > 99)
{
     Console.WriteLine(Find3Int(N));
}
else
    Console.WriteLine("Третьей цифры нет");