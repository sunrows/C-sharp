//Задача-13: Напишите программу, которая выводит третью цифру 
//(справа налево) заданного числа или сообщает, что третьей цифры нет.
System.Console.WriteLine("Введите трехзначное число для вывода последней цифры - числа: ");
int num1 = int.Parse(Console.ReadLine()!);
int num2 = num1 / 100;
num1 %= 10;

if (num2 == 0)
{
    System.Console.WriteLine($"Третей цифры нет!");
} 
else if (num1 != 0)
{
System.Console.WriteLine($"Последняя цифра числа: {num1}");
}
