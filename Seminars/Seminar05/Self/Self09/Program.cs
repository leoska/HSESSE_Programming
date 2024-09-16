using System;
internal class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Введите координаты");
            Console.Write("x - ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y - ");
            double y = double.Parse(Console.ReadLine());
            bool G = (x * x + y * y <= 4 && x >= 0 && x >= y);
            Console.WriteLine(G);
        }
        catch (FormatException)
        {
            Console.WriteLine("Введены некорректные данные");
        }
    }
}
