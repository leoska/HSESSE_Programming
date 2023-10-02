using System;
class Program
{
    static void Triangle(int n) {
        for (int i = 1; i <= n; ++i) {
            for (int j = 1; j <= i; ++j) {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }
    }
    static void Ornament(int n, int m) {
        for (int i = 1; i <= m; ++i) {
            Triangle(n);
        }
    }
    static void Main()  
    {
        int n = int.Parse(Console.ReadLine()), m = int.Parse(Console.ReadLine());
        Ornament(n, m);
    }
}
