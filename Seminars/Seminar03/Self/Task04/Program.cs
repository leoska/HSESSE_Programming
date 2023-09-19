using System.IO;
using System.Text.RegularExpressions;
using System;
class Program
{
    static void Main()
    {
        if (!(double.TryParse(Console.ReadLine(), out double x)))
        {
            Console.WriteLine("Wrong input");
            return;
        }
        if (!(double.TryParse(Console.ReadLine(), out double y)))
        {
            Console.WriteLine("Wrong input");
            return;
        }
        
        double f;
        if (x < y)
        {
            f = Math.Sin(x)+Math.Pow(Math.Cos(y), 2);
        }
        else if (x == y)
        {
            f = Math.Log(Math.Abs(x));
        }
        else
        {
            f = Math.Sin(Math.Pow(x, 2))+Math.Cos(y);
        }

        Console.WriteLine($"x={x}, y={y}, F={f}");
    }
}