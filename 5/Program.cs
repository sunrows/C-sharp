// Задача 5 - 
//Напишите программу, которая на вход принимает
//одно число (N), а на выходе показывает все целые
//числа в промежутке от -N до N.

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int numb = -N;
while (numb <= N)
{
Console.Write($" {numb} ");
numb += 1;
}
