using System;
namespace prak2
{
    internal class Program
    {
        static void Main()
        {
            int n;
            double l;
            int.TryParse(Console.ReadLine(), out n);
            double.TryParse(Console.ReadLine(), out l);
            if (!((1 <= n && n < 11) && (l > 0)))
            {
                Console.WriteLine("Некорректные введенные данные");
            }
            else
            {
                double S;
                S = (double)((n * l * l) / (4 * Math.Tan(Math.PI / n)));
                Console.WriteLine("{0:f2}", S);
            }
            Console.ReadKey();

        }
    }
}




