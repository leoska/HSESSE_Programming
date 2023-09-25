using System;
internal class Programm
{
    static void Main()
    {
        double a = 0;
        double b = 0;
        double c;
        int q = 3;
        do
        {
            c = a;
            a = a + 1.0 / (q * (q - 1) * (q - 2));
            b = c;
            q += 1;
        } while (a - b >= Double.Epsilon);
        Console.WriteLine($"Приближенное значение (double) - {a}");
        float a1 = 0;
        float b1 = 0;
        float c1;
        int q1 = 3;
        do
        {
            c1 = a1;
            a1 = (float)(a1 + 1.0 / (q1 * (q1 - 1) * (q1 - 2)));
            b1 = c1;
            q1 += 1;
        } while (a1 - b1 >= Double.Epsilon);
        Console.WriteLine($"Приближенное значение (float) - {a1}");
    }
}
