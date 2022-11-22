//Задача 14 написать число и чтобы делилась на 7 и 23 одновременно! 
System.Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
if ((num % 7 == 0) && (num % 23 == 0) )
{
    System.Console.WriteLine($"Число {num} кратное 7 и 23! ");
}
else System.Console.WriteLine("Число не кратное!");