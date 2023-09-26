using System;
class Program
{
    static void Main()  
    {
        int k = 0;
        for (int i = 2000; i <= 3000; ++i) {
            int a = i / 1000, b = i / 100 % 10, c = i / 10 % 10, d = i % 10;
            if (a == b || a == c || a == d || b == c || b == d || c == d) {
                continue;
            }
            System.Console.WriteLine(i);
            ++k;
        }
        System.Console.WriteLine(k);
    }
}
