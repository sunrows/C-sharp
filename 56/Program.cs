// Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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


void minRow(int[,] arr)
{
    int[] myArr = new int[arr.GetLength(0)];

    for (int i = 0; i < arr.GetLength(0); i++)

    {
        int tmp = 0;

        for (int j = 0; j < arr.GetLength(1); j++)
        {

            tmp = tmp + arr[i, j];

        }
        myArr[i] = tmp;

        Console.WriteLine($"Сумма {i} -ой строки = {myArr[i]} \t");

    }

    int tmp2 = myArr[0];
    int numOfRow = 0;
    for (int k = 0; k < myArr.Length; k++)
    {

        if (myArr[k] < tmp2)
        {
            tmp2 = myArr[k];
            numOfRow = k;
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {numOfRow} \t");

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

minRow(array);

