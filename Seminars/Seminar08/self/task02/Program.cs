namespace task02
{
    internal class Program
    {
        public static bool Triangle(double x, double y, double z, out double p, out double s)
        {
            if (!(x + y > z && x + z > y && z + y > x) || x<=0 || y<=0 || z<=0)
            {
                p = 0;
                s = 0;
                return false;
            }
            else
            {
                p = x + y + z;
                double p1 = p / 2;
                s = Math.Sqrt(p1 * (p1 - x) * (p1 - y) * (p1 - x));
                return true;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите x, y, z");
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double z = double.Parse(Console.ReadLine());
                bool f=Triangle(x, y, z, out double p, out double s);
                if (f)
                {
                    Console.WriteLine($"периментр = {p}, площадь = {s}");
                }
                else
                {
                    Console.WriteLine("Введены неподходящие данные");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Введены некорректные данные");
            }
        }
    }
}