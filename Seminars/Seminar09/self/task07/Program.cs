namespace task07
{
    internal class Program
    {
        static int[] CreateArr()
        {
            Random rnd = new Random();
            int[] B = new int[10];
            for (int i = 0; i < 10; i++)
            {
                B[i] = rnd.Next(-12, 15);
            }
            return B;
        }
        static void PrintArr(int[] arr)
        {
            foreach(int x in arr)
            {
                Console.Write($"<{x}>");
            }Console.Write(Environment.NewLine);
        }
        static void Main(string[] args)
        {
            int[] A = new int[20] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
            int[] B = CreateArr();
            PrintArr(A);
            PrintArr(B);
            int qchA = 0;
            int[] Ach = new int[20];
            for (int i=0; i < 20; i++)
            {
                if (A[i]%2==0)
                {
                    Ach[qchA++] = A[i];
                }
            }
            Array.Resize(ref Ach, qchA);
            int[] C = new int[10 + qchA];
            for (int i=0;i<10;i++)
            {
                C[i] = B[i];
            }
            Array.Copy(Ach, 0, C, 10, qchA);
            PrintArr(C);


        }
    }
}