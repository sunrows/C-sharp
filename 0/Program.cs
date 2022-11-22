//Задача 0- Программа которая возводит число в квадрат
Console.Clear();
Console.Write("Введите число:");
int number = int.Parse(Console.ReadLine()!);

int sqr = number * number;

Console.WriteLine($" Квадрат числа {number} равна : {sqr}");
