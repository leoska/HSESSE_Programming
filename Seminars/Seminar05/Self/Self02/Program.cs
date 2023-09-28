namespace Self02;
class Program
{
    static void Main()
    {
        int intCount = 0, floatCount = 0, anotherCount = 0;
        do
        {
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int n))
            {
                if (n == 0)
                {
                    break;
                }
                ++intCount;
            }
            else if (double.TryParse(input, out double r))
            {
                ++floatCount;
            }
            else
            {
                ++anotherCount;
            }
        } while (true);
        Console.WriteLine($"Count of integers: {intCount}");
        Console.WriteLine($"Count of real: {floatCount}");
        Console.WriteLine($"Count of strings: {anotherCount}");
    }
}