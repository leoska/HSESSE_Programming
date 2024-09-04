namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            if (1 <= n && n < 11 && l > 0)
            {
                double s = (n * l * l) / (4 * Math.Tan(Math.PI / n));
                Console.WriteLine("{0:f2}", s);
            }
        }
    }
}