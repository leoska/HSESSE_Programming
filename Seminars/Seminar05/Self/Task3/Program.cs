using System;
class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        double s = 0;
        for (int i = 1; i <= n; ++i) {
            double x = a / n * i;
            s += a / n * x * x;
        }
        System.Console.WriteLine(s);
    }
}
