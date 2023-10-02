using System;
class Program
{
    static void Ornament(int n, int m) {
        for (int i = 1; i <= n; ++i) {
            for (int j = 1; j <= m; ++j) {
                for (int k = 1; k <= i; ++k) {
                    System.Console.Write('*');
                }
                for (int k = 1; k <= n - i; ++k) {
                    System.Console.Write(' ');
                }
            }
            System.Console.WriteLine();
        }
    }
    static void Main()  
    {
        int n = int.Parse(Console.ReadLine()), m = int.Parse(Console.ReadLine());
        Ornament(n, m);
    }
}
