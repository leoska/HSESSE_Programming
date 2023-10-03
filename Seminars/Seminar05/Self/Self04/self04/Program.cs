namespace self04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double curSumd = 0;
            float curSumf = 0;

            Console.Write("Введите предел: ");
            int.TryParse(Console.ReadLine(), out int N);
            Console.WriteLine();

            for (int i = 1; i < N; i++)
            {
                curSumd += 1.0 / (i * (i + 1) * (i + 2));
                curSumf += (float)(1.0 / (i * (i + 1) * (i + 2)));
            }

            Console.WriteLine($"double: {curSumd}\t float: {curSumf}");

            
        }
    }
}