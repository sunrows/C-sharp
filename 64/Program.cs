// Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

//Итеративный метод

/*
string numbers(int a)
{
    string result = string.Empty;
    for (int i = a; i >= 1; i--)
    {
        result += $"{i} "; 
    }
    return result;
}

Console.WriteLine("Введите число N :");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{numbers(b)}");

*/

//Рекурсивный метод:

string numbersRec(int a)
{
    if (a >= 1) return $"{a} " + numbersRec(a - 1);
    else return string.Empty;
}
Console.WriteLine(numbersRec(10));
