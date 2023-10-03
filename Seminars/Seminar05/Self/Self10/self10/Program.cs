namespace self10
{
    internal class Program
    {
        static double G(double x)
        {
            if (x <= 0.5)
            {
                return Math.Sin(Math.PI / 2);
            }

            return Math.Sin((Math.PI * (x - 1)) / 2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            double.TryParse(Console.ReadLine(), out double x);
            Console.WriteLine();

            Console.WriteLine(G(x));
        }
    }
}