using System;
class Program
{
    static void Main()  
    {
        while (true) {
            int n;
            double x;
            System.Console.Write("x = ");
            bool isdouble = double.TryParse(Console.ReadLine(), out x);
            System.Console.Write("n = ");
            bool isint = int.TryParse(Console.ReadLine(), out n);
            if (isdouble && isint && n >= 1 && n <= 20) {
                double sum = 0;
                for (int k = 1; k <= n; ++k) {
                    sum += Math.Abs(x - k) * Math.Cos(Math.Cbrt(k) * x / 2);
                }
                double f = (Math.Log(x) - 2.0 / 9) * sum;
                System.Console.WriteLine($"f = {f}");
                System.Console.WriteLine("exit - 0\nnext input - 1");
                int nextaction = int.Parse(Console.ReadLine());
                if (nextaction == 0) {
                    break;
                }
            }
            else {
                System.Console.WriteLine("Wrong input");
                continue;
            }
        }
    }
}
