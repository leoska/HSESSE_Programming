using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, R;
            string ans, v;

            do
            {
                x = Double.Parse(Console.ReadLine());
                y = Double.Parse(Console.ReadLine());
                R = Double.Parse(Console.ReadLine());

                ans = x * x + y * y <= R ? "������" : "�������";
                Console.WriteLine($"{ans}\n���������? (y/n)");
                v = Console.ReadLine();
            } while (v == "y");
        }
    }
}
