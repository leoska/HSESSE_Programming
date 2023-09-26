using System;
class Program
{
    static void Main()  
    {
        int n = int.Parse(Console.ReadLine());
        double a = double.Parse(Console.ReadLine()), A = a;
        double s = 0, p = 1;
        for (int i = 1; i <= n; ++i) {
            s += 1 / A;
            A *= a;
            p *= (a - i);
        }
        System.Console.WriteLine($"S = {s}\nP = {p}");
    }
}
