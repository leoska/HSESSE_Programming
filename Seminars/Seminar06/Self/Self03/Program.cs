using System;
internal class Program
{
    static void Main()
    {
        int q = 0;
        for (int i = 2000; i <= 3000; i++)
        {
            int a = i / 1000;
            int b = i / 100 % 10;
            int c = i / 10 % 10;
            int d = i % 10;
            if (a!=b && a!=c && a!=d && b!=c && b!=d && c!=d)
            {
                Console.WriteLine(i);
            }
        }
    }
}