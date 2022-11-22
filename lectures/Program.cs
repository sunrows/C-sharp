
// int max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }


// int a1 = 2;
// int b1 = 22;
// int c1 = 21;

// int a2 = 12;
// int b2 = 2322;
// int c2 = 32;

// int a3 = 13;
// int b3 = 15;
// int c3 = 216;


// int max = a1;

// if (b1 > max) max = b1;
// if (c1 > max) max = c1;
// if (a2 > max) max = a2;
// if (b2 > max) max = b2;
// if (c2 > max) max = c2;
// if (a3 > max) max = a3;
// if (b3 > max) max = b3;
// if (c3 > max) max = c3;

//Здесь можно применить функции(методы)
//Синтаксис : 
//типВозвращаемогоЗначения имяФункции (типДанных входныеАргументы1, ... ,типДанных входныеАргументыn )

// int max1 = max(a1, b1, c1);
// int max2 = max(a2, b2, c2);
// int max3 = max(a3, b3, c3);
// int max4 = max(max1,max2,max3);


//Тут 4строки кода можно писать на 1 строке:
//int max4 = max (max(a1,b1,c1),max(a2,b2,c2),max(a3,b3,c3));
//Console.WriteLine($"Максимальное число: {max4}");


//Чтобы все переменные одного типа уложить в строку нужны массивы

//Массивы

//типДанных [] имяМассива = new типДанных [количество элементов];

//Прямые инициализации 
//int [] array = new int[5];
//int [] array = {0,0,0,0,0};
//int [] array = new int [] {0,0,0,0,0,0,0,0,0};
//int [] array = new int [5] {0,0,0,0,0};
// Для нашей задачи 
//                          0, 1, 2, 3, 4, 5, 6, 7, 8 -индексы

// int max(int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9 )
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     if (arg4 > result) result = arg4;
//     if (arg5 > result) result = arg5;
//     if (arg6 > result) result = arg6;
//     if (arg7 > result) result = arg7;
//     if (arg8 > result) result = arg8;
//     if (arg9 > result) result = arg9;
//     return result;
// }
// int[] array = new int[9] { 17, 26, 35, 44, 35, 26, 71, 81, 91 };
// int result = max(array[0], array[1], array[2], array[3],array[4],array[5],array[6],array[7],array[8]);
// Console.WriteLine($"Максимальное {result}");




//Задача новая : 
//Имеется одномерный массив array из n элементов, требуется найти индекс элемента массива равный в find
//Решение
//обявляем массив
// int[] mas = new int[] { 11, 2, 33, 42, 5, 16, 76, 89 };
// //индекс для массива
// int index = 0;
// //переменная равная искомому элементу в массиве
// int find = 42;

// while (index < mas.Length)
// {
//     if (mas[index] == find)
//     { Console.WriteLine($"Искомый элемент: {find} находится в индексе: {index}");}
//     index++;
// }


//Задача новая сделаем массивы c рандом 
//void это невозвращаемый тип метода (return не используем!)


void FillArray(int[] collection)
{
    
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)

{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int []collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
        }
            index++;
    }
    return position;
}
int[] array = new int[10];// default {0,0,0,0,0,0,0,0,0,0}
FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 3);//Здесь нужно угадать число!  Если нет напишет -3
Console.WriteLine(pos);


