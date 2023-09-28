namespace Self05;
class Program
{
    static void Main()
    {
        Console.Write("Каков предел суммирования? ");
        if (!uint.TryParse(Console.ReadLine(), out uint n) | n <= 0)
        {
            Console.WriteLine("Invalid input data.");
        }
        else
        {
            Console.Write("Input A: ");
            if (!double.TryParse(Console.ReadLine(), out double a))
            {
                Console.WriteLine("Invalid input data.");
            }
            else
            {
                double sum = 0;
                Console.WriteLine($"Сумма равна {Summ(a, n, sum):f2}");

                double comp = 1;
                Console.WriteLine($"Произведение равно {Composition(a, n, comp):f2}");
            }
        }

        static double Summ(double a, uint n, double sum)
        {
            for (uint i = 1; i <= n; ++i)
            {
                a *= i;
                sum += 1 / a;
            }
            return sum;
        }

        static double Composition(double a, uint n, double comp)
        {
            for (uint i = 1; i <= n; ++i)
            {
                comp *= (a - i);
            }
            return comp;
        }
    }
}
