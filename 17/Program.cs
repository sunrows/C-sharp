// Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.
//             ^ y
//             |
// 2(Вторая)   |   1(Первая)
//             |
//             |
// --------------------------> x
//             |
// 3(Третья)   |   4(Четвертая)
//             |
//             |

int GetQuater(int x, int y)
{
  if (x > 0) 
  {
    if (y > 0)
    {
      return 1;
    }
    else 
    {
      return 4;
    }
  }
  else
  {
   if (y > 0)
    {
      return 2;
    }
    else 
    {
      return 3;
    }
  }
}

Console.Clear();
int X = int.Parse(Console.ReadLine()!);
int Y = int.Parse(Console.ReadLine()!);

int quater = GetQuater(X, Y);
Console.WriteLine($"Четверть: {quater}");
