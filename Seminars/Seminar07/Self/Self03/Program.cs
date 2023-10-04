namespace Self03
{
    internal class Program
    {

        public static string Triangle(int n, string str2)
        {
           
            if (n > 0)
            {
                string str1 = "";
                for (int j = 0; j < n; j++)
                {
                    str1 += "*";
                    str2 = str2.Substring(1);
                }
                return str1 + str2;

            }
            else
            {
                return "";
            }

        }
        public static void Ornament(int n, int m)
        {
            if (m > 0)
            {
                Console.WriteLine($"N = {n} M = {m}");
                string str12 = "";
                for (int i = 0; i < n; i++)
                {
                    str12 += " ";
                }
                for (int i = 1; i < n+1; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write(Triangle(i, str12));
                    }
                    Console.WriteLine("\n");
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