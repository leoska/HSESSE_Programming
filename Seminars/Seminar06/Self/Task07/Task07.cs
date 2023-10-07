using System.Threading.Tasks.Dataflow;
using System;
using System.Xml.Serialization;
using System.Runtime.Intrinsics.Arm;

class LoL { 
    static void Main() {
        double x;
        int n;
        while (!double.TryParse(Console.ReadLine(), out x) || !int.TryParse(Console.ReadLine(), out n)) {
            Console.WriteLine("Wrong input");
        }
        double res = 0;
        for (int i = 1; i <= n; i++) {
            res += Math.Abs(x - i) * Math.Cos(Math.Pow(i, 1.0 / 3) * x / 2);
        }
        Console.WriteLine(Math.Log(x) - 2.0 / 9 * res);
    }
}
