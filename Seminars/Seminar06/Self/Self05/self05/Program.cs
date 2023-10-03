namespace self05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N и A");
            int.TryParse(Console.ReadLine(), out int N);
            double.TryParse(Console.ReadLine(), out double A);
            Console.WriteLine();

            double S = 0;
            double P = 1;

            for (int i = 1; i <= N; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    A *= A;
                }

                S += 1.0 / A;

                P *= (A - i);
            }
        }
    }
}