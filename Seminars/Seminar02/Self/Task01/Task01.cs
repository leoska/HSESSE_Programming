using System.Threading.Tasks.Dataflow;
using System;

class LoL { 
    static void Main() {
        int a = 1;
        double b = 1.234;
        char c = '@';
        
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);

        Console.WriteLine("a - " + a.GetType());
        Console.WriteLine("b - " + b.GetType());
        Console.WriteLine("c - " + c.GetType());
    }
}
