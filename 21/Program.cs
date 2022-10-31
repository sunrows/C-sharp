// Задача 21 Напишите программу которая принимает на вход координаты двух точек и находит расстояние между ними в 3д
//например А(3,6,8); B(2,1,-7) ; 15.84

double Rasstoyanie (int x0, int y0, int x1, int y1, int z0, int z1)
{
    return Math.Sqrt(Math.Pow((x0-x1),2)+Math.Pow((y0-y1),2)+Math.Pow((z0-z1),2));
}
System.Console.WriteLine($"Введите координаты точек в новых строках X0,Y0,X1,Y1,Z0,Z1:");

int X0 = int.Parse(Console.ReadLine()!);
int Y0 = int.Parse(Console.ReadLine()!);
int X1 = int.Parse(Console.ReadLine()!);
int Y1 = int.Parse(Console.ReadLine()!);
int Z0 = int.Parse(Console.ReadLine()!);
int Z1 = int.Parse(Console.ReadLine()!);

System.Console.WriteLine($"Расстояние между точек: ({X0},{Y0})({X1},{Y1})({Z0},{Z1}): {Rasstoyanie(X0,Y0,X1,Y1,Z0,Z1)}");

