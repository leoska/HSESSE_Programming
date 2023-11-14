using System;
class Program
{
    static void Main()
    {
        int kint = 0, kdouble = 0, knan = 0;
        string s;
        do {
            s = Console.ReadLine();
            int a;
            double b;
            bool isint = int.TryParse(s, out a);
            bool isdouble = double.TryParse(s, out b);
            if (isint) {
                ++kint;
            }
            else if (isdouble) {
                ++kdouble;
            }
            else {
                ++knan;
            }
        }
        while (s != "0");
        System.Console.WriteLine("int = " + kint);
        System.Console.WriteLine("double = " + kdouble);
        System.Console.WriteLine("nan = " + knan);
    }
}
