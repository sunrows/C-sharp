//Задача 16 является ли  одного числа квадрату другого

System.Console.WriteLine("Введите  первое число: ");
int num1 = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);

if (num1 == (num2 * num2) || num2 == (num1 * num1))
{
    System.Console.WriteLine("Условия выполнены!");
}
else System.Console.WriteLine("Условия не выполнены!");

