using System.Threading.Tasks.Dataflow;
using System;
using System.Xml.Serialization;

class LoL { 
    static void Main() {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        bool g;
        if (x * x + y * y <= 2 * 2 && x >= 0 && y <= x) {
            g = true;
        }
        else {
            g = false;
        }
        Console.WriteLine(g);
    }
}
