//Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите число");
int number1 = int.Parse(Console.ReadLine()!);
int number2 = number1 / 10 % 10;
Console.WriteLine($"Вторая цифра: {number2}");

