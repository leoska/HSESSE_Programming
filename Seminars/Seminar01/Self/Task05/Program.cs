
using System;

class Task5{
    static void Main(string[] args)
    {
        Console.Write("Введите напряжение: ");
        double U = double.Parse(Console.ReadLine());
        Console.Write("Введите сопротивление: ");
        double R = double.Parse(Console.ReadLine());

        double I = U/R;
        double P = I*U;

        Console.WriteLine($"Сила тока равна: {I}");
        Console.WriteLine($"Потребляемая мощность электрической цепи равна: {P}");

    }
}