using System;
internal class Program
{
    static void Main()
    {
        static double Gres(double x)
        {
            if (x <= 0.5)
            {
                return (Math.Sin(Math.PI / 2));
            }
            else
            {
                return (Math.Sin(Math.PI * (x - 1) / 2));
            }
        }
        try
        {
            Console.Write("Введите число: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine(Gres(x));
        }
        catch (FormatException)
        {
            Console.WriteLine("Введены некорректные данные");
        }
    }
}