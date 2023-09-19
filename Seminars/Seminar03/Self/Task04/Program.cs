using System;
class Program
{
    static void Main()
    {
        double x = Convert.ToDouble(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine());
        double f = 0.0;
        if (x < y)
        {
            f = Math.Sin(x) + Math.Cos(y) * Math.Cos(y);
        }
        else if (x == y)
        {
            f = Math.Log(Math.Abs(x));
        }
        else
        {
            f = Math.Sin(x * x) + Math.Cos(y);
        }
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(f);
    }
}
