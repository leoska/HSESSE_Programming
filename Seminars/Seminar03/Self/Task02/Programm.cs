using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            string ans;
            x = Double.Parse(Console.ReadLine());
            y = Double.Parse(Console.ReadLine());
            z = Math.Sqrt(x * x + y * y);
            switch (z)
            {
                case < 1:
                case > 2: ans = "Не принадлежит"; break;
                case 1:
                case 2: ans = "На границе"; break;
                default: ans = "Принадлежит"; break;
            }
            Console.WriteLine(ans);
        }
    }
}