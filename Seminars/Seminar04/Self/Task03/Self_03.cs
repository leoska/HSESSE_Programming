using System.Threading.Tasks.Dataflow;
using System;

class LoL { 
    static void Main() {
        Console.WriteLine("Введите код операции: ");
        int x;
        int.TryParse(Console.ReadLine(), out x);

        Console.WriteLine("Введите A: "); 
        double A;
        double.TryParse(Console.ReadLine(), out A);

        Console.WriteLine("Введите B: ");
        double B;
        double.TryParse(Console.ReadLine(), out B);

        if (x is int && A is double && B is double) {
            string result = x switch {
                1 => (A + " + " + B + " = " + (A + B)),
                2 => (A + " - " + B + " = " + (A - B)),
                3 => (A + " * " + B + " = " + (A * B)),
                4 => (A + " / " + B + " = " + (A / B)),
                _ => ("Данные некорректны")
            };
            Console.WriteLine(result);
        }
        else {
            Console.WriteLine("Данные некорректны");
        }
        
    }
}
