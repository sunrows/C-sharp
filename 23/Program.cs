// Задача 23- Задать число / и до этого числа все числа возводит в куб,
System.Console.WriteLine("Введите предел числа для возведения их в куб: ");
int num1 = int.Parse(Console.ReadLine()!);
int i = 1;
double Kub(double x)
{
    double result = Math.Pow(x,3);
    return result;
}
while (i <= num1)
{
    System.Console.WriteLine($"{i}^3: {Kub(i)}");
    i++;
}


