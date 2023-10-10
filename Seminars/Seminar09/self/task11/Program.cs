namespace task11
{
    internal class Program
    {
        static void PrintArr(int[] arr)
        {
            foreach (int x in arr)
            {
                Console.Write($"<{x}>");
            }
            Console.Write(Environment.NewLine);
        }
        static void Input(out int n)
        {
            while (true)
            {
                Console.WriteLine($"Введите N:");
                if (int.TryParse(Console.ReadLine(), out n) && n > 1)
                {
                    Console.WriteLine("Успешно введено");
                    return;
                }
                Console.WriteLine("Введенные значения некорретны, повторите ввод");
            }
        }
        static void Main(string[] args)
        {
            Input(out int n);
            int[] A = new int[n];
            A[0] = 1;
            A[1] = 1;
            for (int i = 2; i < n; i++)
            {
                A[i] = A[i - 1] + A[i - 2];
            }
            PrintArr(A);
        }
    }
}