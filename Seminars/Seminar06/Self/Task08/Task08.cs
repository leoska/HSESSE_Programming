using System.Threading.Tasks.Dataflow;
using System;
using System.Xml.Serialization;
using System.Runtime.Intrinsics.Arm;

class LoL { 
    static void Main() {
        while (true) {
            int n, m;
            double x0, z0, dX, dZ;
            if (!int.TryParse(Console.ReadLine(), out n) || !int.TryParse(Console.ReadLine(), out m) || !double.TryParse(Console.ReadLine(), out x0) || !double.TryParse(Console.ReadLine(), out z0) || !double.TryParse(Console.ReadLine(), out dX)  || !double.TryParse(Console.ReadLine(), out dZ)) {
                Console.WriteLine("Некорректные данные");
                return;
            }
            double x = x0, z = z0;
            for (int i = 1; i <= n; i++) {
                double F1 = x * Math.Atan(x / Math.Sqrt(z)) - Math.Log(Math.Pow(x * x + z, 1.0 / 3)) + 1;
                double F2 = Math.Pow(Math.E, Math.Sqrt(z)) + Math.Pow(Math.Pow(x, 4), 1.0 / 3) * (1 + (x - z / x) / (x + z / x)) * Math.Abs(Math.Sin(x));

                Console.WriteLine($"X = {x}, Z = {z}, F1 = {F1}, F2 = {F2}");

                x += dX;
                z += dZ;
            }
        }
    }
}
