using System;

class Program
{
    public static void Main()
    {
        Console.Write("Введите R: ");
        int R = int.Parse(Console.ReadLine());
        Console.Write("Введите U: ");
        int U = int.Parse(Console.ReadLine());
        Console.WriteLine($"Сила тока: {U / R}");
        Console.WriteLine($"Мощность цепи: {Math.Pow(U, 2) / R}");
    }
}