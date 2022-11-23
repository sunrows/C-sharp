// Считать сколько чисел больше 0 ввел пользователь! 

Console.WriteLine(" Введите числа:");

void massive(int[] array)
{
    int i = 0;
    while (i < array.Length)
    {
        Console.WriteLine(" Введите числа с Enter!");
        array[i] = int.Parse(Console.ReadLine()!);
        i++;
    }
}

string ConsoleArr(int [] mass)
{
    return "{" + string.Join(",", mass) + "}";
}

int sumOfNumber(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0)
        {
            sum++;
        
        }
    }
    return sum;
}

Console.WriteLine(" Введите длину массива");
int numberOfElements = int.Parse(Console.ReadLine()!);
int [] getArray = new int [numberOfElements];
massive(getArray);
int Sum = sumOfNumber(getArray);
Console.WriteLine(ConsoleArr(getArray));

Console.WriteLine($" Количество положительных чисел: {Sum}");