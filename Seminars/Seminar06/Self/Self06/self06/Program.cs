namespace self06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 0;

            for (int n = 5; n <= 12; n++)
            {

                int summ = 0;
                for (int k = 1; k <= n; k++)
                {
                    int fact = 1;
                    for (int j = k; j >= 1; j--)
                    {
                        fact *= j;
                    }
                    summ += fact;
                }

                Console.WriteLine(summ);
            }
        }
    }
}