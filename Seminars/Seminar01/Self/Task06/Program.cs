using System;

class LoL { 
    static void Main() {
        double c1 = double.Parse(Console.ReadLine());
        double c2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Длина гипотенузы: " + Math.Sqrt(c1 * c1 + c2 * c2));
    }
}
