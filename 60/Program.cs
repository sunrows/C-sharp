

// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

int[,,] GetArray(int m, int n, int k)
{
    int[,,] result = new int[m, n, k];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int z = 0; z < n; z++)
            {
                result[i, j, z] = new Random().Next(10, 100);
            }
        }
    }
    return result;
}


void PrintArray(int[,,] inArray)
{
    Console.WriteLine($"A[i,j,k] = \t");
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int z = 0; z < inArray.GetLength(1); z++)
            {

                Console.Write($"{inArray[i, j, z]+ " " + (i,j,z)} \t");
            }

        }
        Console.WriteLine();
    }
}

// Для первой матрицы

Console.Write(" Введите количество строк :");
int x = int.Parse(Console.ReadLine()!);

Console.Write(" Введите количество столбцов :");
int y = int.Parse(Console.ReadLine()!);

Console.Write(" Введите количество объема:");
int z = int.Parse(Console.ReadLine()!);

int[,,] array1 = GetArray(x, y, z);

PrintArray(array1);