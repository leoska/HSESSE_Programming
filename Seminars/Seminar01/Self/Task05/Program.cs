using System;

class LoL { 
    static void Main() {
        double U = double.Parse(Console.ReadLine()); 
        double R = double.Parse(Console.ReadLine()); 

        Console.WriteLine("Сила тока: " + (U / R));
        Console.WriteLine("Потребляемая мощность электрической цепи: " + (U * U / R));
    }
}
