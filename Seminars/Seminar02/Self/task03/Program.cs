using System;
 internal class Program
    {
        static void Main()
        {
        int x, y, z;
        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());
        z = int.Parse(Console.ReadLine());
        Console.WriteLine($"Изначальные значения переменных: x - {x}, y - {y}, x - {z}");
        int x1 = (x <= y && x <= z) ? x : ((y <= x && y <= z) ? y : z);
        int z1 = (x >= y && x >= z) ? x : ((y >= x && y >= z) ? y : z);
        int y1 = x + y + z - x1 - z1;
        Console.WriteLine($"Отыорматированные значения переменных: x - {x1}, y - {y1}, z - {z1}");

        }
    }
