//Задача 25: напишем цикл, который принимает на вход 2 числа (а и b) и 
//возводит число a на b т.е. a^b=c 3^5=243

Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine()!);
int i = 0;
int res = 1;
while (i < b)
{
    res *= a;
    i += 1;
}
System.Console.WriteLine($"a= {a}; b= {b};");
System.Console.WriteLine($"a^b =: {res} ");
