// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.Clear();

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

// Для первой матрицы

Console.Write(" Введите количество строк первой матрицы:");
int rows = int.Parse(Console.ReadLine()!);

Console.Write(" Введите количество столбцов первой матрицы:");
int cols = int.Parse(Console.ReadLine()!);

Console.Write(" Введите минимальное число первой матрицы:");
int minValue = int.Parse(Console.ReadLine()!);

Console.Write(" Введите максимальное число первой матрицы:");
int maxValue = int.Parse(Console.ReadLine()!);

int[,] array1 = GetArray(rows, cols, minValue, maxValue);

PrintArray(array1);

// Для второй матрицы

Console.Write(" Введите количество строк второй матрицы:");
rows = int.Parse(Console.ReadLine()!);

Console.Write(" Введите количество столбцов второй матрицы:");
cols = int.Parse(Console.ReadLine()!);

Console.Write(" Введите минимальное число второй матрицы:");
minValue = int.Parse(Console.ReadLine()!);

Console.Write(" Введите максимальное число второй матрицы:");
maxValue = int.Parse(Console.ReadLine()!);

int[,] array2 = GetArray(rows, cols, minValue, maxValue);

PrintArray(array2);

int [,] resultOfArray(int[,] arr1, int[,] arr2)
{

    if (arr1.GetLength(1) == arr2.GetLength(0))
    {
        int[,] resArray = new int[arr1.GetLength(0), arr2.GetLength(1)];
        for (int i = 0; i < resArray.GetLength(0); i++)
        {
            for (int j = 0; j < resArray.GetLength(1); j++)
            {
                for (int k = 0; k < arr1.GetLength(1); k++)
                {
                    resArray[i,j] += arr1[i,k] * arr2[k,j];
                }
            }

        }

        return resArray;
    }
    else 
    {
        throw new Exception("Non-conformable matrices in MatrixProduct");
    }
}

int [,] myArray = resultOfArray(array1,array2);
Console.WriteLine(" Произведение двух матриц:");
PrintArray(myArray);






