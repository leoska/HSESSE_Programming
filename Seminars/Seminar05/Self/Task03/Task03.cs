using System.Threading.Tasks.Dataflow;
using System;
using System.Xml.Serialization;

class LoL { 
    static void Main() {
        double A = double.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        double h = A / n, tec = h, res = 0;
        while (n > 0) {
            res += tec * tec;
            tec += h;
            --n;
        }
        res *= h;
        Console.WriteLine(res);
    }
}
