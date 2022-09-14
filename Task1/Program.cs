//Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите число");
int number1 = int.Parse(Console.ReadLine()!);
if (number1<=999 && number1 >=100)
{
int number2 = number1 / 10 % 10;
Console.WriteLine($"Вторая цифра: {number2}");
}
else
{
    Console.WriteLine("Ошибка");
}
