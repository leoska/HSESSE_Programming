namespace task10
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
        static void Input(out int n, out int a, out int d)
        {
            while (true)
            {
                Console.WriteLine($"Введите N, A, D:");
                if (int.TryParse(Console.ReadLine(), out n) && int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out d) && n>1)
                {
                    Console.WriteLine("Успешно введено");
                    return;
                }
                Console.WriteLine("Введенные значения некорретны, повторите ввод");
            }
        }
        static void Main(string[] args)
        {
            int n,a,d;
            Input(out n, out a, out d);
            int[] A = new int[n];
            for (int i=0;i<n;i++)
            {
                A[i] = a + i * d;
            }
            Console.WriteLine("Полученный масив:");
            PrintArr(A);
        }
    }
}