namespace Task05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d, x1, x2;
            Console.WriteLine($"{a}*x^2 + {b}*x + {c} = 0");
            if (a != 0 && b != 0)
            {
                d = b * b - 4 * a * c;
                if (d > 0)
                {
                    x1 = -b - Math.Pow(d, 0.5) / 2 * a;
                    x2 = -b + Math.Pow(d, 0.5) / 2 * a;
                    Console.WriteLine(x1);
                    Console.WriteLine(x2);
                }
                else if (d == 0)
                {
                    Console.WriteLine(-b / (2 * a));
                }
                else
                {
                    Console.WriteLine("Нет действительных корней.");
                }
            }
            else if (a == 0 && b != 0)
            {
                Console.WriteLine(-c / b);
            }
            else if (b == 0 && a != 0)
            {
                d = -4 * a * c;
                if (d > 0)
                {
                    Console.WriteLine(- Math.Pow(d, 0.5) / 2 * a);
                    Console.WriteLine(Math.Pow(d, 0.5) / 2 * a);
                }
                else if (d == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine("Нет действительных корней.");
                }
            }
            else
            {
                Console.WriteLine("Нет действительных корней.");
            }
        }
    }
}