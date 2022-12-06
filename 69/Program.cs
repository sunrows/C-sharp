// Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.

int square(int a, int b)
{
    if (b==0) return 1;
    return square(a, b-1)*a;
}

Console.Clear();
Console.WriteLine(" Введите число А:");

int a = int.Parse(Console.ReadLine()!);

Console.WriteLine(" Введите число B:");

int b = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{square(a,b)}");

