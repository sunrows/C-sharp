//Задача-15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
System.Console.WriteLine("Введите число соответствующему дню недели: ");

int num1 = int.Parse(Console.ReadLine()!);
if (num1 >= 1 && num1 <= 5)
{ 
    System.Console.WriteLine("Денек то рабочий!");
}
else 
System.Console.WriteLine("Выходной! Ура!");