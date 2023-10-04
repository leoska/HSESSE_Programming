using System;
class Program
{
    static void Python(int n) {
        for (int i = 1; i <= n; ++i) {
            for (int j = 1; j <= n * 2; ++j) {
                System.Console.Write('*');
                Thread.Sleep(25);
                if (i == 1 && j % 2 == 1 || i == n && j % 2 == 0 && j < 2 * n) {
                    System.Console.Write('*');
                }
                else {
                    System.Console.Write(' ');
                }
                Thread.Sleep(25);
            }
            System.Console.WriteLine();
        }
    }
    static void Main()  
    {
        int n = int.Parse(Console.ReadLine());
        Python(n);
    }
}
