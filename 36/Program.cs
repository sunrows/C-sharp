//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue+1);
    }

    return array;
}

void sumOfOddPositions(int[] array)
{
    int sum = 0; 
    
    for (int i = 1; i < array.Length; i+=2 ) 
    {
        sum += array[i];
    }

    Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");
}

int[] array = GetArray(6,0,145);
Console.WriteLine(String.Join(" ", array));
sumOfOddPositions(array); 
