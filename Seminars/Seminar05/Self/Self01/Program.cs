using System;
namespace task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                if (n == 20)
                {
                    continue;
                }
                else if (n % 2 == 0 && n % 3 == 0)
                {
                    Console.WriteLine($"{n} - число, кратное 2 и 3");

                }
                else
                {
                    Console.WriteLine($"Число {n} не соответствует условию");
                }
            } while (++n <= 50);
        }
    }
}