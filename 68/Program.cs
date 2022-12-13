// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// n = 2, m = 3 -> A(n,m) = 9
// n = 3, m = 2 -> A(n,m) = 29

int akkerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return akkerman(n - 1, 1);
    else
      return akkerman(n - 1, akkerman(n, m - 1));
}

Console.WriteLine("Введите число n:");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число m:");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Число Аккермана: {akkerman(a,b)}");