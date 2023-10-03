namespace self05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите k: ");
            if (!int.TryParse(Console.ReadLine(), out int k))
            {
                Console.WriteLine("ошибка");
                return;
            }
            Console.WriteLine();

            double summ = 0;

            for (int i = 1; i <= k; i++)
            {
                summ += 1.0 / i;
            }

            Console.WriteLine(Math.Round(summ, 4));
        }
    }
}