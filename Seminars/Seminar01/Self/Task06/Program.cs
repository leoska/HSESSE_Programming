using System;

class Program
{
    public static void Main()
    {
        Console.Write("Введите длину катета1: ");
        int k1 = int.Parse(Console.ReadLine());
        Console.Write("Введите длину катета2: ");
        int k2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Гипотенуза: {Math.Sqrt(k1*k1 + k2*k2)}");
    }
}