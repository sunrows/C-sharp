//Задача 36- Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }

    return res;
}

void CountNumbers(int[] array)
{
    int different = 0;
    int minElement = 0;
    int maxelement = 0;
    int i = 0;
    while ( i < (array.Length-1))
    {
        minElement = array[i+1] < array[i] ? array[i+1] : array[i];
        maxelement = array[i+1] > array[i] ? array[i+1] : array[i];
        i++;
    }

    different = maxelement - minElement;
        
    Console.WriteLine($"минимальное число: {minElement}");
    Console.WriteLine($"максимальное число: {maxelement}");
    Console.WriteLine($"Разница: {different}");
}

int[] array = GetArray(10, 0, 9);
Console.WriteLine(String.Join(" ", array));
CountNumbers(array);