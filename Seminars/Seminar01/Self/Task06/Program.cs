using System;
class Program
{
    static void Main(string[] args)
    {
        float a, b;
        a = float.Parse(Console.ReadLine());
        b = float.Parse(Console.ReadLine());
        Console.WriteLine(Math.Pow((Math.Pow(a, 2) + Math.Pow(b, 2)), 0.5));

    }
}