// ЗАдайте двумерынй массив.Найдиет элементы у которыз оба индекса четные 
// и замените эти элементы на их квадраты

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
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void PowsOfArr(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) inArray[i, j] *= inArray[i, j];
            Console.Write($"{inArray[i, j]} \t");
        }
        Console.WriteLine();
    }
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
Console.WriteLine();

PowsOfArr(array);