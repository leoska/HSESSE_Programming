using System;
internal class Program
    {
        static void Main()
        {
        try
        {
            double R = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            string res = ((x * x + y * y <= R * R) ? "Точка внутри круга!" : "Точка вне круга!");
            Console.WriteLine(res);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Введены некорректные данные");
        }
            
        }
    }
