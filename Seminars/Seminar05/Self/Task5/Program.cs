using System;
class Program
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        double ans = 0;
        for (int i = 1; i <= k; ++i) {
            ans += 1.0 / i;
        }
        System.Console.WriteLine("{0:F4}", ans);
    }
}
