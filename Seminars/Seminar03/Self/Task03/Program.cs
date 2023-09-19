using System;
class Program
{
    static void Main()
    {
        double x = Convert.ToDouble(Console.ReadLine()), y = Convert.ToDouble(Console.ReadLine());
        double d = Math.Sqrt(x * x + y * y);
        if (d < 2 && y > 0 || d < 1 && y <= 0)
        {
            Console.WriteLine("Точка попадает во внутрь области.");
        }
        else if (y > 0 && d == 2 || y == 0 && d >= 1 && d <= 2 || y < 0 && d == 1)
        {
            Console.WriteLine("Точка попадает на границу области.");
        }
        else
        {
            Console.WriteLine("Точка не принадлежит области.");
        }
    }
}
