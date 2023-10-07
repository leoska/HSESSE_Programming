using System.Threading.Tasks.Dataflow;
using System;

class LoL { 
    static void Main() {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double f = 0;
        if (x < y) f = Math.Sin(x) + Math.Cos(y) * Math.Cos(y);
        if (x == y) f = Math.Log(Math.Abs(x));
        if (x > y) f = Math.Sin(x) * Math.Sin(x) + Math.Cos(y);

        Console.WriteLine("x = " + x);
        Console.WriteLine("y = " + y);
        Console.WriteLine("f = " + f);
    }
}
