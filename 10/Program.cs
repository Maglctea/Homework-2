Console.WriteLine("Введите число: ");

int N = Convert.ToInt32(Console.ReadLine());

if (N < 1000 && N > 99)
    Console.WriteLine(N % 100 / 10);
else
    Console.WriteLine("Недопустимое число");