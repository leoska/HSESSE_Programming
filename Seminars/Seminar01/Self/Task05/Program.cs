using System;
class Program
{
    static void Main()
    {
        double U, R;
        Console.Write("Введите значение напряжения(U): ");
        U = double.Parse(Console.ReadLine());
        Console.Write("Введите значение сопротивления(R): ");
        R = double.Parse(Console.ReadLine());
        Console.WriteLine($"Сила тока: I={U / R}");
        Console.WriteLine($"Потребляемая мощность электрической цепи: P={U*U / R}");
        Console.ReadLine();
    }
}