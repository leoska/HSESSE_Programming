using System;
class Program
{
    static void Main()
    {
        double s = 0;
        int a = 1, b = 2, c = 3;
        for (int i = 1; i <= 1000; ++i) {
            s += 1.0 / (a * b * c);
            ++a;
            ++b;
            ++c;
        }
        System.Console.WriteLine(s);
    }
}
