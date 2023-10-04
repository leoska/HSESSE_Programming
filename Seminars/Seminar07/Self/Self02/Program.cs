namespace Self02
{
    internal class Program
    {
        public static void Ornament(int n, int m) 
        { 
            if (m > 0)
            {
                Console.WriteLine($"N = {n} M = {m}");
                for (int j = 0; j < m; j++)
                {
                    string str = "";
                    for (int i = 0; i < n; i++)
                    {
                        str += "*";
                        Console.WriteLine(str);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            Ornament(n, m);
        }
    }
}