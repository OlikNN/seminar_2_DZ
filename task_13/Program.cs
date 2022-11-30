// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    while (number >= 100)
    {
        Console.WriteLine($"  {number}");
        if (number <= 999) Console.WriteLine($" третий знак {number % 10}");
        number /= 10;
        int d = number % 10;
    }
}
else
{
    Console.WriteLine($"Третьей цифры нет");
}


