using System;
class Program
{
    static void Main()  
    {
        for (int n = 5; n <= 12; ++n) {
            int s = 0;
            for (int k = 1; k <= n; ++k) {
                int fac = 1;
                for (int i = 1; i <= k; ++i) {
                    fac *= i;
                }
                s += fac;
            }
            System.Console.WriteLine($"S({n}) = {s}");
        }
    }
}
