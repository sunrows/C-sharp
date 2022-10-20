//Задача 6-Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

System.Console.WriteLine("Введите число для проверки четности: ");
int num1 = int.Parse(Console.ReadLine()!);
int num2 = num1 % 2;
if (num2 == 0)
{
    System.Console.WriteLine($"Число {num1}, четный!");
}
else
{
    System.Console.WriteLine($"Число {num1}, нечетный!");
}