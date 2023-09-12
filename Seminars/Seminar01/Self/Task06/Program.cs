using System;
class Program
{
    static void Main()
    {
        double a, b;
        Console.WriteLine("Введите значения 2х катетов:");
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        Console.WriteLine($"Длина гипотенузы равна {Math.Sqrt(a*a+b*b)}");
        Console.ReadLine();
    }
}