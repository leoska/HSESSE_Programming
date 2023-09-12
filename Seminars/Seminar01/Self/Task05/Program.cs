using System;

class Program {
    static void Main() {
        Console.Write("Введите напряжение: ");
        double u=Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите сопротивление ");
        double r=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Сила тока = "+(u/r));
        Console.WriteLine("Потребляемая мощность электрической цепи: "+(u*u/r));
    }
}
