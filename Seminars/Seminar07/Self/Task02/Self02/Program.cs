namespace Self02
{
    internal class Program
    {


        public static void Ornament(int n, int m)
        {
            for (int i = 0; i < m; i++)
            {
                TriangleClass.Triangle(n);
            }
        }
        static void Main(string[] args)
        {
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0 && int.TryParse(Console.ReadLine(), out int m) && m > 0)
            {
                Ornament(n, m);
            }
        }
    }
}