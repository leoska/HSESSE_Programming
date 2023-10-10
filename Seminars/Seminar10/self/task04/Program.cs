namespace task04
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
        static void FirstChetToSecond(ref int[] A, ref int[] B)
        {
            if (A == null || A.Length == 0)
            {
                return;
            }
            int[] Ach = new int[A.Length];
            int qch = 0;
            foreach (int a in A)
            {
                if (a % 2 == 0)
                {
                    Ach[qch++] = a;
                }
            }
            Array.Resize(ref Ach, qch);
            Array.Resize(ref B, B.Length + qch);
            Array.Copy(Ach, 0, B, B.Length - qch, qch);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины массивов");
            int na = int.Parse(Console.ReadLine());
            int nb = int.Parse(Console.ReadLine());
            int[] A = new int[na];
            int[] B = new int[nb];
            Random rnd = new Random();
            for (int i = 0; i < na; i++)
            {
                A[i] = rnd.Next(-100, 101);
            }
            for (int i = 0; i < nb; i++)
            {
                B[i] = rnd.Next(-100, 101);
            }
            Print_Array(A);
            Print_Array(B);
            Console.Write(Environment.NewLine);
            FirstChetToSecond(ref A, ref B);
            Print_Array(A);
            Print_Array(B);
        }
    }
}