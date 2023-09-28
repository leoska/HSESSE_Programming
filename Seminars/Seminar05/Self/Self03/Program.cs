namespace Task03;
class Program
{
    static void Main()
    {
        Console.Write("До какого значения по оси абсцисс ищем площадь? ");
        if (double.TryParse(Console.ReadLine(), out double a) & a >= 0)
        {
            Console.Write("На сколько интервалов разбиваем? ");
            if (uint.TryParse(Console.ReadLine(), out uint n) & n > 0)
            {
                double S = 0;
                double interval = a == 0 ? 1 : a / n;
                for (double intervalEnd = interval; intervalEnd <= a; intervalEnd += interval)
                {
                    double averageLength = (intervalEnd * intervalEnd +
                        + (intervalEnd - interval) * (intervalEnd - interval)) / 2;
                    S += averageLength * interval;
                }
                if (int.TryParse(Convert.ToString(S), out int intS))
                {
                    Console.WriteLine($"Площадь под графиком равна {S}");
                }
                else
                {
                    Console.WriteLine($"Площадь под графиком равна {S:f2}");
                }
            }
            else
            {
                Console.WriteLine("Invalid data.");
            }
        }
        else
        {
            Console.WriteLine("Invalid data.");
        }

    }
}