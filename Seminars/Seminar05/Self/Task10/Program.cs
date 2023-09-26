using System;
class Program
{
    static double G(double x) {
        if (x <= 0.5) {
            return Math.Sin(Math.PI / 2);
        }
        return Math.Sin(Math.PI * (x - 1) / 2);
    }
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        System.Console.WriteLine(G(x));
    }
}
