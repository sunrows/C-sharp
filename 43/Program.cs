// Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 *
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 =
// 9 -> (-0,5; -0,5)

int[] Pounds()
{
    int[] mas = new int[4];
    string[] arr = { "b1", "k1", "b2", "k2" };
    for (int i = 0; i < mas.Length; i++)
    {
        
        Console.WriteLine($" Введите точку {arr[i]}:\t");
        mas[i] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(mas[i]);
    }
    return mas;
}

void Method(int[] array)
{
    int b1 = array[0];
    int k1 = array[1];
    int b2 = array[2];
    int k2 = array[3];
    double x, y;
    if (b1 == b2 && k1 == k2) Console.WriteLine(" Прямые совпадают");
    else if (k1 == k2) Console.WriteLine(" Прямые паралельны!");
    else
    {
    x = (b2 - b1) / (k2 - k1);
    y = k1 * x + b1;
    Console.WriteLine($" Точка пересечения x = {x}; y = {y}");
    }
}

Method(Pounds());
