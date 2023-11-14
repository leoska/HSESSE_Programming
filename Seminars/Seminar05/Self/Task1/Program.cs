using System;
class Program
{
    static void Main()
    {
        for (int i = 1; i <= 50; ++i) {
            if (i == 20) {
                continue;
            }
            if (i % 2 == 0 && i % 3 == 0) {
                System.Console.WriteLine(i + " делится на 2 и 3");
            }
            else {
                System.Console.WriteLine(i + "  не делится на 2 и 3");
            }
        }
    }
}
