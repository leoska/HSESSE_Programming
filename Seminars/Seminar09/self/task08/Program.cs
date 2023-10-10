namespace task08
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
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N>0");
            int n;
            int.TryParse(Console.ReadLine(), out n);
            if (n<=0)
            {
                Console.WriteLine("Неверный ввод");
                return;
            }
            int[] A = new int[n];
            for (int i=0;i<n;i++)
            {
                A[i] = (int)Math.Pow(2, i);
            }
            PrintArr(A);
        }
    }
}