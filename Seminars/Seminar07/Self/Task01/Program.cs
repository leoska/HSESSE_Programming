using System;1
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
    static void Main()  
    {
        int n = int.Parse(Console.ReadLine());
        Triangle(n);
    }
}
