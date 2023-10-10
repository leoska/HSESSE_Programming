
using System;

namespace task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите n: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("введите m: ");
                int m = int.Parse(Console.ReadLine());
                Methods.Triangle(n, m);
            }
            catch
            {
                Console.WriteLine("Введены некорректные значения");
            }
        }
    }
}