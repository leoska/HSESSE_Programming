using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double l, ans;

            n = int.Parse(Console.ReadLine());
            if (n <= 2)
            {
                Console.WriteLine("Неверный ввод!");
                return;
            }
            l = Double.Parse(Console.ReadLine());

            ans = (n * l * l / (4 * Math.Tan(Math.PI / n)));

            Console.WriteLine(ans);
        }
    }
}