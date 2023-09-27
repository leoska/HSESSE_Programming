using System;
class Program
{
    static void Main()  
    {
        bool p = false, q = false;
        do {
            do {
                bool f = !(p & q) & !(p | !q);
                System.Console.WriteLine(p + " " + q + " " + f);
                q = !q;
            }
            while (q);
            p = !p;
        }
        while (p | q);
    }
}
