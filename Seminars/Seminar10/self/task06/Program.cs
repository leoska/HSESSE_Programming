namespace task06
{
    internal class Program
    {
        public static void Print_Array(int[] ar)
        {
            foreach (int x in ar)
            {
                Console.Write($"<{x}>");
            }
            Console.Write(Environment.NewLine);
        }
        static int BeSmallerSmall(ref int[] A)
        {
            int q = 0;
            int i = 0;
            do
            {
                if ((A[i] + A[i + 1]) % 3 == 0)
                {
                    A[i] = A[i] * A[i + 1];
                    for (int j = i + 1; j + 1 < A.Length; j++)
                    {
                        A[j] = A[j + 1];
                    }
                    Array.Resize(ref A, A.Length - 1);
                    q++;
                }
                i++;
            } while (i + 1 < A.Length);
            return q;
        }

        static int BeSmallerBig(ref int[] A)
        {
            int sum = 0;
            bool f;
            do
            {
                int res = BeSmallerSmall(ref A);
                f = res != 0 ? true : false;
                sum += res;

            } while (f);
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во элементов массива");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                A[i] = rnd.Next(-100, 100);
            }
            Print_Array(A);
            int res = BeSmallerBig(ref A);
            Console.WriteLine($"Кол-во сжатий = {res}");
            Console.Write("Массив: ");
            Print_Array(A);

        }
    }
}