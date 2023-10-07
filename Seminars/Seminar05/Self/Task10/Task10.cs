using System.Threading.Tasks.Dataflow;
using System;
using System.Xml.Serialization;


class LoL { 
    static double F(double X) {
        if (X <= 0.5) {
            return Math.Sin(Math.PI / 2);
        }
        else {
            return Math.Sin(Math.PI * (X - 1) / 2);
        }
    }
    static void Main() {
        double x = double.Parse(Console.ReadLine());
        double G = F(x);
        Console.WriteLine(G);
    }
}
