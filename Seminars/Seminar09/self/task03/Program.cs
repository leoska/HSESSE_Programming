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
                Array.Sort(A);
                Array.Reverse(A);
                foreach (int x in A)
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