//Задача 1 
//Написать 2 числа и проверить является ли первое число квадрату второго

Console.Clear();
Console.Write("Введите 1 ое число и второе сразу:");
int number1 = int.Parse(Console.ReadLine()!);
int number2 = int.Parse(Console.ReadLine()!);

if (number1 == Math.Pow(number2, 2))
{

    Console.WriteLine($" Первое число является квадратом второго.");

}
else
{
    Console.WriteLine($" Условие не выполнено!");
};