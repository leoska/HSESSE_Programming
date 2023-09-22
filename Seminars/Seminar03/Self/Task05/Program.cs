namespace Task05
{
    class Program
    {
        static double ReadDouble()
        {
            return double.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            double a = ReadDouble();
            double b = ReadDouble();
            double c = ReadDouble();

            if(a == 0)
            {
                Console.WriteLine($"{b}x + {c} = 0");
                Console.WriteLine($"x = {-c / b}");
            }
            else
            {
                double D = b*b - 4*a*c;
                if (D < 0)
                {
                    Console.WriteLine("Нет действительных корней");
                }
                else
                {
                    Console.WriteLine($"{a}x^2 + {b}x + {c} = 0");
                    Console.WriteLine($"x1 = {(-b + Math.Sqrt(D)) / (2 * a)}; x2 = {(-b - Math.Sqrt(D)) / (2 * a)}");
                }
            }
        }
    }
}
