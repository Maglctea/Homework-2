bool CheckDay(int numberDay)
{
    return numberDay > 5 && numberDay < 8 ? true : false;
}

Console.WriteLine("Введите число: ");

int N = Convert.ToInt32(Console.ReadLine());

if (N > 7 || N < 1)
    Console.WriteLine("Недопустимое число");
else if (CheckDay(N))
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");
