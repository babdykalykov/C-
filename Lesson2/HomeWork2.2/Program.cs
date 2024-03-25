// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
//            |
//            |
//      2     |      1
//            |
// -----------------------
//            |
//      3     |      4
//            |
//            |

Console.WriteLine("Ведите координату Х");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите координату Y");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0) Console.WriteLine("Координатная четверть - 1");
else if (x < 0 && y > 0) Console.WriteLine("оординатная четверть - 2");
else if (x < 0 && y < 0) Console.WriteLine("оординатная четверть - 3");
else if (x > 0 && y < 0) Console.WriteLine("оординатная четверть - 4");
else Console.WriteLine("Ошибка!");