namespace Self01
{
    internal class Program
    {

        public static void Triangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int n);
            
            if (n > 0)
            {
                Triangle(n);
            }
        }
    }
}