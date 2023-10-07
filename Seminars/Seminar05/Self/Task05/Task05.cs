using System.Threading.Tasks.Dataflow;
using System;
using System.Xml.Serialization;

class LoL { 
    static void Main() {
        int k = int.Parse(Console.ReadLine());
        double res = 1;
        for (int i = 2; i <= k; ++i) {
            res += (double)1 / i;
        }
        res = Math.Round(res, 4);
        Console.WriteLine(res);
    }
}
