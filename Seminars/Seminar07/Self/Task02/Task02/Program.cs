namespace Task02
{
    internal class Program
    {
        static void Triangle(int a)
        { 
                string s = "";
                for (int i = 0; i < a; i++)
                {
                    s += "*";
                    Console.WriteLine(s);

                }   
        }
        static void Ornament(int n, int m)
        {
            if (m > 0)
            {
                for (int i = 0; i < m; i++)
                {
                    Triangle(n);
                }
            }
            else
            {
                return;
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            Ornament(n,m);
        }
    }
}