namespace Self08;
class Program
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        if (!int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine("Invalid input data.");
        }
        else
        {
            Console.Write("Enter count of digits: ");
            if (!int.TryParse(Console.ReadLine(), out int k))
            {
                Console.WriteLine("Invalid input data.");
            }
            else
            {
                int length;
                for (length = 1; (n / (int)Math.Pow(10, length) > 0); length++) { }
                if (length > k)
                {
                    Console.WriteLine(n / (int)Math.Pow(10, length - k));
                }
                else
                {
                    Console.WriteLine("Too much digits");
                }
                
            }
        }
    }
}