using System;
class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine()), b = double.Parse(Console.ReadLine());
        double c = Math.Sqrt(a * a + b * b);
        Console.WriteLine(c);
    }
}
