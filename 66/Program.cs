// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int sumOfNumbers(int m, int n)
{
    
    if (n >= m) return m + sumOfNumbers(m+1, n);
    else return 0;
}


Console.WriteLine("Введите число M:");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число N:");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine("Сумма чисел: " );
Console.WriteLine(sumOfNumbers(a,b));

