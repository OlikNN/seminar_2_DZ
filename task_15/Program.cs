// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите ваше число от 1 до 7:");
string? answer = Console.ReadLine();
int number = Convert.ToInt32(answer);

if (number > 7 || number < 1)
{
    Console.WriteLine("Число должно быть от 1 до 7");
}

if (number < 6)
{
    Console.WriteLine("Нет");
} 
else
{
    Console.WriteLine("Да");
}
