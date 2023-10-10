namespace Task03
{
    internal class Program
    {
        //static void Triangle(int a)
        //{
            //    string s = "";
            //    for (int i = 0; i < a; i++)
            //    {
            //        s += "*";
            //        Console.WriteLine(s);

            //    }
            //}
            //static void Ornament(int n, int m)
            //{
            //    if (m > 0)
            //    {
            //        for (int i = 0; i < m; i++)
            //        {
            //            Triangle(n);
            //        }
            //    }
            //    else
            //    {
            //        return;
            //    }
            //}

            static void Ornament(int n, int m)
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= m; j++)
                    {
                        for (int q = 1; q <= i; q++)
                        {
                            Console.Write('*');
                        }
                        for (int q = 1; q <= n - i; q++)
                        {
                            Console.Write(' ');
                        }
                    }
                    Console.WriteLine();
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