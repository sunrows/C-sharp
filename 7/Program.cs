/*Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает последнюю цифру
этого числа.*/
Console.WriteLine(" Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()!);
int check = num / 1000;
if (check == 0)
{
    int check2 = num % 10;
    Console.WriteLine($"Последнее число {check2}");
}
else
{   
    Console.WriteLine(" Число не соответствует условиям! ");
}
