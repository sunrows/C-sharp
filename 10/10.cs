//Задача-10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
System.Console.WriteLine("Введите трехзначное число для вывода средней цифры - числа: ");
int num1 = int.Parse(Console.ReadLine()!);
num1 %= 100;
int num2 = num1/10;
if (num2 != 0)
{
System.Console.WriteLine($"Средняя цифра числа: {num2}");
}
else
{
    System.Console.WriteLine($"Вы ввели недопустимые числа!");
}

