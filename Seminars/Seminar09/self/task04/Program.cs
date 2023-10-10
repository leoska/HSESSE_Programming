namespace task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random rnd = new Random();
                Console.WriteLine("Введите N:");
                int N = int.Parse(Console.ReadLine());
                int[] A = new int[N];
                for (int i = 0; i < N; i++)
                {
                    A[i] = rnd.Next(-2, 8);
                }
                int qch = 0;
                int qnch = 0;
                foreach (int x in A)
                {
                    if (x % 2 == 0)
                    {
                        qch += 1;
                    }
                }
                qnch = N - qch;
                int[] B = new int[qch];
                int[] C = new int[qnch];
                qch = 0;
                qnch = 0;
                foreach (int x in A)
                {
                    if (x % 2 == 0)
                    {
                        B[qch++] = x;
                    }
                    else
                    {
                        C[qnch++] = x;
                    }
                }
                Console.WriteLine("Изначальный массив:");
                foreach (int x in A)
                {
                    Console.Write($"<{x}>");
                }
                Console.WriteLine("\nМассив четных:");
                foreach (int x in B)
                {
                    Console.Write($"<{x}>");
                }
                Console.WriteLine("\nМассив нечетных:");
                foreach (int x in C)
                {
                    Console.Write($"<{x}>");
                }
            }
            catch
            {
                Console.WriteLine("Введены некуорретные данные");
            }

        }
    }
}