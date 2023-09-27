using System;
using System.Reflection.Metadata.Ecma335;
class Program
{
    static void Main()  
    {
        int nextaction = 1;
        while (nextaction == 1) {
            try {
                System.Console.Write("funtype = ");
                int funtype = int.Parse(Console.ReadLine());
                if (funtype != 1 && funtype != 2) {
                    System.Console.WriteLine("wrong fun type");
                    continue;
                }
                System.Console.Write("n = ");
                int n = int.Parse(Console.ReadLine());
                System.Console.Write("x0 = ");
                double x0 = double.Parse(Console.ReadLine());
                System.Console.Write("dx = ");
                double dx = double.Parse(Console.ReadLine());
                System.Console.Write("m = ");
                int m = int.Parse(Console.ReadLine());
                System.Console.Write("z0 = ");
                double z0 = double.Parse(Console.ReadLine());
                System.Console.Write("dz = ");
                double dz = double.Parse(Console.ReadLine());
                double x = x0;
                for (int i = 1; i <= n; ++i) {
                    double z = z0;
                    for (int j = 1; j <= m; ++j) {
                        double f = 0;
                        if (funtype == 1) {
                            f = x * Math.Atan(x / Math.Sqrt(z)) - Math.Log(Math.Cbrt(x * x + z)) + 1;
                        }
                        else {
                            f = Math.Pow(Math.E, Math.Sqrt(z)) + Math.Cbrt(x * x * x * x) * (1 + (x - z / x) / (x + z / x)) * Math.Abs(Math.Sin(x));
                        }
                        System.Console.WriteLine($"x = {x}\tz = {z}\t f = {f}");
                        z += dz;
                    }
                    x += dx;
                }
                System.Console.WriteLine("exit - 0\nnext - 1");
                nextaction = int.Parse(Console.ReadLine());
            }
            catch {
                System.Console.WriteLine("wrong input");
            }
        }
    }
}
