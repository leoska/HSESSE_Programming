using System;
class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine()), k = int.Parse(Console.ReadLine());
        if (Math.Pow(10, k - 1) <= x) {
            while (Math.Pow(10, k) <= x) {
                x /= 10;
            }
            System.Console.WriteLine(x);
        }
        else {
            System.Console.WriteLine("wrong input.");
        }
    }
}
