using System;
class Program
{
    static void Main()
    {
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(a + "*x^2 + " + b + "*x + " + c + "= 0");
        if (a == 0)
        {
            Console.WriteLine("x = " + -c / b);
        }
        else
        {
            double d = b * b - 4 * a * c;
            Console.WriteLine(d);
            if (d == 0)
            {
                Console.WriteLine("x = " + -b / (2 * a));
            }
            else if (d < 0)
            {
                Console.WriteLine("Нет действительных корней.");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("x1 = " + x1 + "\nx2 = " + x2);
            }
        }
        
    }
}
