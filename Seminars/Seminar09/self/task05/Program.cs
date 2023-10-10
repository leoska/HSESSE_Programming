namespace task05
{
    internal class Program
    {

        static int[] CreateArr(int n)
        {
            Random rnd = new Random();
            int[] ar = new int[n];
            for (int i = 0; i < n; i++) 
            {
                ar[i] = rnd.Next(1, 6);
            }
            return ar;
        }
        static void SetArr(ref int[] ar)
        {
            int[] arrExist = new int[ar.Length];
            int q = 0;
            for (int i=0;i<ar.Length;i++)
            {
                if (Array.IndexOf(arrExist, ar[i])!=-1)
                {
                    ar[i] = 0;
                }
                else
                {
                    arrExist[q++] = ar[i];
                }
            }
            Array.Resize(ref arrExist, q - 1);
        }
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                Console.WriteLine("Введите N - кол-во эл-ов массива");
                if (int.TryParse(Console.ReadLine(), out n) && n>=0)
                {
                    Console.WriteLine("N введено");
                    break;
                }
                Console.WriteLine("Введено некорректное значение N, повторите ввод");
            }
            int[] ar = CreateArr(n);
            foreach(int x in ar)
            {
                Console.Write(x + " ");
            }
            Console.Write(Environment.NewLine);
            SetArr(ref ar);
            foreach (int x in ar)
            {
                Console.Write(x + " ");
            }
        }
    }
}