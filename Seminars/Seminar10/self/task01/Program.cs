namespace task01
{
    internal class Program
    {
        static void PrintArr(double[] ar)
        {
            foreach(double x in ar)
            {
                Console.Write($"<{x:F3}>");
            }Console.Write(Environment.NewLine);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива");
            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            double min = -12.25;
            double max = 12.25;
            double range = max - min;
            double[] A = new double[n];
            for (int i=0;i<n;i++)
            {
                A[i] = range * rnd.NextDouble() + min;
            }
            PrintArr(A);
        }
    }
}