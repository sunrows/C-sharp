/*Напишите программу, которая выводит случайное
трёхзначное число и удаляет вторую цифру этого
числа.*/
Console.WriteLine(" Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()!);
int check = num / 1000;
if (num != 0)
{
    int num2 = (num / 100 * 10)+(num%10);
    Console.WriteLine($" Среднее число: {num2} ");
}
else { Console.WriteLine(" Введен не то число! "); };
