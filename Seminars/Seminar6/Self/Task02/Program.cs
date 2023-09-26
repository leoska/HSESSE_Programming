using System;
class Program
{
    static void Main()  
    {
        bool a = false, b = false, c = false;
        do {
            do {
                do {
                    bool f = !(a | b & c) | a;
                    System.Console.WriteLine($"{a} {b} {c} {f}");
                    c = !c;
                }
                while (c);
                b = !b;
            }
            while (b);
            a = !a;
        }
        while(a);
    }
}
