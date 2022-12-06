// Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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


void maxminsort(int[,] arr)
{
    Console.WriteLine("Соритировка пузырком - наоборот");
    for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k = arr.GetLength(1) - 1; k > j; k--)
            if (arr[i, k] > arr[i, k - 1])
            {
                int tmp = arr[i, k];
                arr[i, k] = arr[i, k - 1];
                arr[i, k - 1] = tmp; ;
            }
        Console.Write($"{arr[i, j]} \t");
    }
    Console.WriteLine();
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

maxminsort(array);
