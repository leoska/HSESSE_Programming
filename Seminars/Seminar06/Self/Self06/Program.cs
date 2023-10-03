using System;
internal class Program
{
    static void Main()
    {

        for (int n=5;n<=12;n++)
        {
            int res = 0;
            int fact = 1;
            for (int k=1; k<=n;k++)
            {
                fact = fact * k;
                res = res + fact;
            }
            Console.WriteLine($"При n = {n} S(n) = {res}");
        }
    }
}