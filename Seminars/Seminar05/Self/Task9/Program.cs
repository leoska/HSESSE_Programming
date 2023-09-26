using System;
class Program
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine());
        double d = Math.Sqrt(x * x + y * y);
        bool g = d <= 2 && x >= 0 && x >= y;
        System.Console.WriteLine(g);
    }
}
