/*Напишите программу, которая будет принимать
на вход два числа и выводить, является ли второе
число кратным первому. Если число 2 не кратно числу
1, то программа выводит остаток от деления*/
Console.WriteLine(" Введите первое число:");
int num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine(" Введите воторое число:");
int num2 = int.Parse(Console.ReadLine()!);

int check = num1 % num2;
if (check == 0)
{
    Console.WriteLine($" Число {num2} кратен числу {num1}");
}
else
{
    Console.WriteLine($" остаток от деления = {check}");
}