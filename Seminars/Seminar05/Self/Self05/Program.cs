namespace Self05;
class Program
{
    static void Main()
    {
        if (!uint.TryParse(Console.ReadLine(), out uint k) | k <= 0) // Проверка на корректность входных данных.
        {
            Console.WriteLine("Invalid input data.");
        }
        else
        {
            double sum = 0;
            for (uint i = 1; i <= k; ++i)
            {
                sum += 1.0f / i;
            }
            Console.WriteLine($"{sum:f4}");
        }
    }
}