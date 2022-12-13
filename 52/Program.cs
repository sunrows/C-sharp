// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.
// : Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}


void PrintArray(int[,] inArray)
{
    Console.WriteLine($"A[i,j] = \t");
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {

            Console.Write($"{inArray[i, j]} \t");
        }
        Console.WriteLine();
    }
}


void average(int[,] arr)
{

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            average = average + arr[i,j];
             
        }
        double result = average/arr.GetLength(0);
        Console.WriteLine($"Результат для столбца:{j} = {average}/{arr.GetLength(0)} ={result};");
    }
}

Console.Write(" Введите количество строк:");
int rows = int.Parse(Console.ReadLine()!);

Console.Write(" Введите количество столбцов:");
int cols = int.Parse(Console.ReadLine()!);

Console.Write(" Введите минимальное число:");
int minValue = int.Parse(Console.ReadLine()!);

Console.Write(" Введите максимальное число:");
int maxValue = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, cols, minValue, maxValue);

PrintArray(array);

average(array);
