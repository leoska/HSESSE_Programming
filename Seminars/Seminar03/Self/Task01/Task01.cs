using System.Threading.Tasks.Dataflow;
using System;

class LoL { 
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        double l = double.Parse(Console.ReadLine());

        double s = (n * l * l) / (4 * Math.Tan(Math.PI / n));

        Console.WriteLine("S = " + s);
    }
}
