using System;
    internal class Program
    {
        static void Main(string[] args)
        {
        float F,x,y;
        try
        {
            x = float.Parse(Console.ReadLine());
            y = float.Parse(Console.ReadLine());
            if (x < y)
            {
                F = (float)(Math.Sin(x) + Math.Pow(Math.Cos(y), 2));
            } 
            else if (x==y)
            {
                F = (float)(Math.Log(Math.Abs(x)));
            }
            else
            {
                F = (float)(Math.Sin(x * x) + Math.Cos(y));
            }
            Console.WriteLine($"Значение x - {x}");
            Console.WriteLine($"Значение y - {y}");
            Console.WriteLine($"Значение F - {F}");
        }
        catch(FormatException ex)
        {
            Console.WriteLine("Введены некорректные данные");
        }
        }
    }
