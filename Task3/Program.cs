//Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int number1 = int.Parse(Console.ReadLine()!);


if (number1<=999 && number1 >=100)
{
    int number2 = number1 % 10;
Console.WriteLine($"Третья цифра: {number2}");
}
if (number1>=1000)
{
    int number2 = number1/10 % 10;
    Console.WriteLine($"Третья цифра: {number2}");
}
if (number1<=99)
{
    Console.WriteLine("Третьей цифры нет");
}