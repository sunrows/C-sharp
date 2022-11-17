
/*
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }

    return res;
}

void CountNumbers(int[] array)
{
    int positiveSum = 0;
    int negativeSum = 0;

    foreach (int el in array)
    {
        positiveSum += el > 0 ? el : 0;
        negativeSum += el < 0 ? el : 0;
    }

    Console.WriteLine($"Сумма положительных элементов: {positiveSum}");
    Console.WriteLine($"Сумма отрицательных элементов: {negativeSum}");
}

int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(" ", array));
CountNumbers(array);



//Задача 32- Напишем программу на замену элекменту массива на обратные значения 

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int [size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);  
    }
    return res;
}
void Function(int[] array)
{
    for(int i= 0; i < array.Length; i++)
    {
        array[i] = -array[i]; 
    }    
}
int [] array = GetArray(4, -9, 8);
Console.WriteLine(String.Join(",", array));
Function(array);
Console.WriteLine(String.Join(",", array));

//Задача 33- Напишем программу которая пишет присутствует ли введенное число в массиве:
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
void FindNumber(int[] array, int N)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == N)
        {
            Console.Write("Да");
            return;
        }

    }
    Console.Write("Нет");
}
int[] array = GetArray(5, -9, 9);
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(String.Join(",", array));
FindNumber(array, N);


//Задача 35 : Задайте массив из 123 случайных чисел / Найдите количесвто элементов массива, значение 
//которых лежат  отрезке [10 99]
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int FindNumber(int[] array)
{   int countIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i]<=99)
        {
            countIndex += 1;
        }
        
    }
    return countIndex;
   
}
int[] array = GetArray(12, -10, 100);
Console.WriteLine(String.Join(",", array));
int countIndex2 = FindNumber(array);
Console.WriteLine($"В массиве :{countIndex2} элементов");

//Задача 37 : [1,2,3,4,5] - > [1*5, 2*4, 3] 

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int [] doubleNum(int[] array)
{   
    int size = array.Length / 2;

    if (array.Length % 2 != 0)
    {
        size++;
    }
    int [] result = new int [size];

    for (int i = 0; i < (array.Length/2); i++)
    {
        result[i] = array[i]* array[array.Length - i - 1];     
    }

    if (array.Length % 2 != 0)
    {
       result[size-1] = array[array.Length / 2 ];
    }

    return result ;
   
}
int[] array = GetArray(5, -5, 5);
Console.WriteLine(String.Join(",", array));
int [] array2 = doubleNum(array);
Console.WriteLine(String.Join(",", array2)); 
*/