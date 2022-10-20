//Задача 4-Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
System.Console.WriteLine("Введите первое число для сравнения: ");
int num1 = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Введите второе число для сравнения: ");
int num2 = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Введите третое число для сравнения: ");
int num3 = int.Parse(Console.ReadLine()!);

if (num1 > num2 && num1 > num3)
{
    System.Console.WriteLine($"Первое число {num1}, максимальный");
}
if (num2 > num1 && num2 > num3)
{
    System.Console.WriteLine($"Второе число {num2}, максимальный");
}
if (num3 > num1 && num3 > num2)
{
    System.Console.WriteLine($"Третье число {num3}, максимальный");
}
