using System;
    internal class Program
    {
        static void Main(string[] args)
        {
        try
        {
            int a1 = int.Parse(Console.ReadLine());
            int a = Math.Abs(a1);
            Console.WriteLine(a / 100);
            Console.WriteLine(a / 10 % 10);
            Console.WriteLine(a % 10);


        }
        catch (FormatException ex)
        {
            Console.WriteLine("Введены некорректные данные");
        }
        }
    }
