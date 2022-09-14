
//Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

Console.WriteLine("Введите число");
int a =int.Parse(Console.ReadLine());
if (a<=999 && a >=100)
{
int number1 = (a/100);
int number = a%10;
Console.WriteLine($"{number1}{number}");
}
else
{
    Console.WriteLine("Ошибка");
}


