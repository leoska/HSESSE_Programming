namespace task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите N:");
                int N = int.Parse(Console.ReadLine());
                int[] A = new int[N];
                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine("Введите значение элемента");
                    A[i]= int.Parse(Console.ReadLine());
                }
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