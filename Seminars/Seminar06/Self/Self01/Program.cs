
using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            bool p = false;
            bool q = false;
            do
            {
                do
                {
                    bool F = !(p & q) & !(p | !q);
                    Console.WriteLine($"p={p} q={q} F={F}");
                    q = !q;
                } while (q);
                p = !p;
            } while (p);
        }
    }
