

//Задача 2- на вход 2 числа на выход показывает какое меньше какое больше!
System.Console.WriteLine("Введите первое число для сравнения: ");
int num1 = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Введите второе число для сравнения: ");
int num2 = int.Parse(Console.ReadLine()!);

if (num1>num2)
{
    System.Console.WriteLine($"Первое число {num1}, больше чем второе число {num2}");
}
else if (num2>num1)
{
    System.Console.WriteLine($"Второе число {num2}, больше чем первое число {num1}");
}
else{
System.Console.WriteLine("Числа либо равны. Или в строке недопустимые символы!");
}
