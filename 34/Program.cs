
//Задача 34 Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет количество 
//чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

int[] GetArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 999);
    }

    return array;
}

void CountNumbersOfEvenNumbers(int[] array)
{
    int countOfEvens = 0; 

    foreach (int elements in array)
    {
        countOfEvens += (elements%2) != 0 ? 0 : 1;
    }

    Console.WriteLine($"Количество четных трехзначных чисел: {countOfEvens}");
}

int[] array = GetArray(12);
Console.WriteLine(String.Join(" ", array));
CountNumbersOfEvenNumbers(array);
