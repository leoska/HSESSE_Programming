using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        double l = Convert.ToDouble(Console.ReadLine());
        double s = n * l * l / (4 * Math.Tan(Math.PI / n));
        Console.WriteLine(s);
    }
}
