using System;

class Program {
    static void Main() {
        Console.Write("Введите длину первого катета: ");
        double a=Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите длину второго катета ");
        double b=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Гипотенуза = "+ Math.Pow((Math.Pow(a,2)+Math.Pow(b,2)),0.5));
    }
}
