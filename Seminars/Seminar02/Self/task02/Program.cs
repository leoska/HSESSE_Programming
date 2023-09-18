using System; 
internal class Program
    {
        static void Main()
        {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        int a1 = (int)Math.Truncate(a);
        int b1 = (int)Math.Truncate(b);
        Console.WriteLine("Сумма целых частей чисел " + a + " и " + b + " равна " + (a1+b1));
        float a2, b2;
        a2 = (float)(a - a1);
        b2 = (float)(b - b1);
        Console.WriteLine("Сумма дробных частей чисел " + a + " и " + b + " равна " + (float)(a2+b2));
        }
    }
