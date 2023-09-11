
using System;

class Task6{
    static void Main(string[] args)
    {
        Console.Write("Введите первый катет: ");
        double A = double.Parse(Console.ReadLine());
        Console.Write("Введите второй катет: ");
        double B = double.Parse(Console.ReadLine());

        double C =  Math.Sqrt(A*A + B*B);
        Console.WriteLine($"Гипотенуза равна: {C}");

    }
}