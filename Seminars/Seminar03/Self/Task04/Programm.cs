using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            double ans;
            x = Double.Parse(Console.ReadLine());
            y = Double.Parse(Console.ReadLine());
            z = x - y;

            switch (z)
            {
                case < 0: ans = Math.Sin(x) + Math.Pow(Math.Cos(y), 2.0); break;
                case 0: ans = Math.Log10(Math.Abs(x)); break;
                default: ans = Math.Cos(y) + Math.Pow(Math.Sin(x), 2.0); break;
            }
            Console.WriteLine(ans);


        }
    }
}