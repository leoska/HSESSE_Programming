namespace Self09;
class Program
{
    static void Main()
    {
        if (!double.TryParse(Console.ReadLine(), out double x) |
            !double.TryParse(Console.ReadLine(), out double y))
        {
            Console.WriteLine("Invalid input data.");
        }
        else
        {
            bool result;
            if (y <= x & x >= 0 & x * x + y * y <= 4)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}