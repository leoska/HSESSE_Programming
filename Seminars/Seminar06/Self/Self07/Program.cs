namespace Self07;
class Program
{
    static void Main()
    {
        uint n;
        double x;
        bool repeat = true;
        double result;
        do
        {
            Console.Write("Input value of x: ");
            if (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Wrong input");
            }
            else
            {
                Console.Write("Input value of n: ");
                if (!uint.TryParse(Console.ReadLine(), out n) | 0 >= n | n > 20)
                {
                    Console.WriteLine("Wrong input");
                }
                else
                {
                    double sum = 0;
                    for (uint k = 1; k <= n; ++k)
                    {
                        sum += Math.Abs(x - k) * Math.Cos(Math.Pow(k, 1 / 3) * x / 2);
                    }

                    result = (Math.Log(x) - 2 / 9) * sum;
                    Console.WriteLine(result);

                    Console.WriteLine("If you want to repeat calculations, tap '1', else tap another button.");
                    if (Console.ReadKey().Key != ConsoleKey.D1)
                    {
                        repeat = false;
                    }
                    Console.WriteLine();
                }
            }
        } while (repeat);
    }
}