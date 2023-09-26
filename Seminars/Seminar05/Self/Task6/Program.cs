using System;
class Program
{
    static void Main()
    {
        for (int i = 100; i <= 999; ++i) {
            if (i % 10 == i / 10 % 10 && i % 10 == i / 100) {
                System.Console.WriteLine(i);
            }
        }
    }
}
