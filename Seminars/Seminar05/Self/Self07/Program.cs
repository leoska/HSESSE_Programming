namespace Self07;
class Program
{
    static void Main()
    {
        int n;
        if (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Invalid input data.");
        }
        else
        { 
            int reversedN = 0, num = n;
            do
            {
                reversedN *= 10;
                reversedN += num % 10;
                num /= 10;
            } while (num > 0);
            Console.WriteLine($"Reversed Number for {n} is {reversedN}");
        }
    }
}