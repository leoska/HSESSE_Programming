namespace Self06;
class Program
{
    static void Main()
    {
        if (!uint.TryParse(Console.ReadLine(), out uint n) | n <= 0)
        {
            Console.WriteLine("Invalid input data.");
        }
        else
        {
            uint sum = 0, comp = 1; 
            for (uint m = 1; m <= n; ++m)
            {
                comp *= m;
                sum += comp;
                Console.WriteLine($"При n = {m} значение суммы равно {sum}");
            }
        }
    }
}