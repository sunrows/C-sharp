//Задача 27: Напишите программу, которая на вход принимает число и суммирует цифры
//например 452-> 11 (тобишь 4+5+2 )
Console.Write("Введите число для суммирования цифер:");
int n = int.Parse(Console.ReadLine()!);
int res = 0;
int b = 10;
int i = n;
while (i > 0)
{ 
    res += (n%b);
    i=n/10;
    n/=10;    
}


System.Console.WriteLine($"Сумма цифер числа: {res}");
