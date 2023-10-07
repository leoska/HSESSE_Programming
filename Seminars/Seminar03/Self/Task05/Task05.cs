using System.Threading.Tasks.Dataflow;
using System;

class LoL { 
    static void Main() {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a == 0) {
            Console.WriteLine(b + "*x +" + c);
            Console.WriteLine("x = " + (-c / b));
        }
        else if (b == 0) {
            Console.WriteLine(a + "*x^2 + " + c);
            if (-c / a > 0) Console.WriteLine("x = +-" + Math.Sqrt(-c / a));
            else if (-c / a == 0) Console.WriteLine("x = 0");
            else Console.WriteLine("Корней нет");
        }
        else {
            Console.WriteLine(a + "*x^2 + " + b + "*x +" + c);
            double d = b * b - 4 * a * c;
            if (d > 0) {
                Console.WriteLine("x1 = " + ((-b + Math.Sqrt(d)) / 2 / a) + "x2 = " + ((-b - Math.Sqrt(d)) / 2 / a));
            }
            else if (d == 0) {
                Console.WriteLine("x = " + ((-b + Math.Sqrt(d)) / 2 / a));
            }
            else {
                Console.WriteLine("Корней нет");
            }
        }
    }
}
