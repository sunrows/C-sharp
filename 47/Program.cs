// Задайте массив m на n  заполненыый вещественными числами:
//Будем взять числа рандомно! 


double[,] mainArray()
{
    Console.WriteLine(" Введите числа строк:");
    int m = int.Parse(Console.ReadLine()!);
    Console.WriteLine(" Введите числа столбцов:");
    int n = int.Parse(Console.ReadLine()!);
    Console.WriteLine(" Введите минимум:");
    double minimum = double.Parse(Console.ReadLine()!);
    Console.WriteLine(" Введите максимум:");
    double maximum = double.Parse(Console.ReadLine()!);

    double[,] array = new double[m, n];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * (maximum - minimum) + minimum;; // Тут Random-но присваивает значения
        }
    } return array; 
}

void PrintArray(double[,] inArray)
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

Console.Clear();

double [,] array = mainArray();

PrintArray(array);
