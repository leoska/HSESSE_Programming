using System.Threading.Tasks.Dataflow;
using System;

class LoL { 
    static void Main() {
        double a = 1.234;
        double b = 5.678;

        Console.WriteLine("Сумма целых частей чисел " + a + " и " + b + " равна " + ((int)a + (int)b));
        Console.WriteLine("Сумма дробных частей чисел " + a + " и " + b + " равна " + (a - (int)a + b - (int)b));
    }
}
