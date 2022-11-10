// Задача 29 программа которая задает массив из 8 элементов и выводит их на экран
//1,2,5,7,9,6,76,67 -> [1,2,5,7,9,6,76,67]

/* Эту часть не допёр! 
Console.Write("Введите целые числа через ", " :");
string input = Console.ReadLine()!;
int [] num;
int accum = 0;

num = Array.ConvertAll(input.Split(","), int.Parse);

for (int i = 0; i<num.Length; i++)
    accum ^=num[i];
    Console.WriteLine($"Строка: {accum}");*/

int [] nums = new int[8];
int i = 0;
while (i < nums.Length)
{
Console.Write($"Введите {i}-ое число :");
nums [i]= int.Parse(Console.ReadLine()!);
i ++;
}
for (i = 0; i<nums.Length; i++)
{
    Console.Write($"{nums[i]}  ");
}



