using System;
class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int a = x;
        while (a > 0) {
            if (a % 10 != 0) {
                System.Console.Write(a % 10);
            }
            a /= 10;
        }
    }
}
