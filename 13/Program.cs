Console.WriteLine("Введите число: ");

int N = Convert.ToInt32(Console.ReadLine());

if (N > 99)
{
    while (N / 1000 != 0)
        N /= 10;
    Console.WriteLine(N % 10);
}
else
    Console.WriteLine("Третьей цифры нет");