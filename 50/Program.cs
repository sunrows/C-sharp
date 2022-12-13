// : Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


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

void SearchInIndexes(int[,] inArray, int index_i, int index_j)
{ 
    if (index_i < inArray.GetLength(0)&&index_j<inArray.GetLength(1))
    {    
    
    Console.Write($"Значение элемента под индексами A[{index_i},{index_j}]={inArray[index_i, index_j]} \t");
    
    }
    else 
    {
      Console.Write($"Значение элемента под индексами A[{index_i},{index_j}] выходит из горизонта массива.\t");
    }
    ;

}
Console.Clear();

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

Console.Write(" Введите номер строки:");
int ind_i = int.Parse(Console.ReadLine()!);

Console.Write(" Введите номер столбца:");
int ind_j = int.Parse(Console.ReadLine()!);

SearchInIndexes(array, ind_i, ind_j);

Console.WriteLine();