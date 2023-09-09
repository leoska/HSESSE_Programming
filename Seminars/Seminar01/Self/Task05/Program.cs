using System;
class Program
{
    static void Main()
    {
        double u = double.Parse(Console.ReadLine()), r = double.Parse(Console.ReadLine());
        double i = u / r, p = u * u / r;
        Console.WriteLine(i + " " + p);
    }
}
