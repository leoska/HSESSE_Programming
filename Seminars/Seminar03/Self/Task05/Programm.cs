using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, D, ans1 = 0, ans2 = 0;
            string ans = "";
            a = Double.Parse(Console.ReadLine());
            b = Double.Parse(Console.ReadLine());
            c = Double.Parse(Console.ReadLine());

            D = b * b - 4 * a * c;
            switch (D)
            {
                case < 0: Console.WriteLine("Корней нет"); return;
                case 0: Console.WriteLine(-b / (2 * a)); return;
                case > 0: ans1 = (-b + Math.Sqrt(D)) / (2 * a); ans2 = (-b - Math.Sqrt(D)) / (2 * a); break;
            }

            Console.WriteLine($"{ans1} {ans2}");


        }
    }
}