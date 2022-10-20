
//Задача 8 - Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
System.Console.WriteLine("Введите число для вывода всех четных чисел в диапазоне (0->N): ");
int num1 = int.Parse(Console.ReadLine()!);
int a1 = 0;
while ( a1 <= num1) 
{
    System.Console.WriteLine($"{a1}");
    a1 += 2;
}