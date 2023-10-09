namespace task04_03
{
    internal class Program
    {
        static void MinMax(ref double x, ref double y)
        {
            double z = x;
            x = Math.Max(x, y);
            y = Math.Min(z, y);
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите A, B, C, D");
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
                double d = double.Parse(Console.ReadLine());


                MinMax(ref a, ref b);
                MinMax(ref c, ref d);
                MinMax(ref b, ref d);
                MinMax(ref a, ref c);
                Console.WriteLine($"Максимальное число - {a}, минимальное - {d}");




            }
            catch (FormatException)
            {
                Console.WriteLine("Введены некорректные данные");
            }
        }
    }
}