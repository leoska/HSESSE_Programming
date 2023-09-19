using System;
    internal class Program
    {
        static void Main()
        {
        float a, b, c,res, res2,D;
        try
        {
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine());
            if (a==0 && b==0)
            {
                if (c==0)
                {
                    Console.WriteLine("Бесконечно много решений");
                }
                else
                {
                    Console.WriteLine("Нет решений");
                }
            }
            else if (a==0)
            {
                res = (float)(-c / b);
                Console.WriteLine($"x = {res}");
            }
            else
            {
                D = (float)(b * b - 4 * a * c);
                if (D<0)
                {
                    Console.WriteLine("Нет действительных корней");
                }
                else if (D==0)
                {
                    res = (float)(-b / (2 * a));
                    Console.WriteLine($"x = {res}");
                }
                else
                {
                    res = (float)((-b + Math.Sqrt(D)) / (2 * a));
                    res2 = (float)((-b - Math.Sqrt(D)) / (2 * a));
                    Console.WriteLine($"x1 = {res}, x2 = {res2}");

                }
            }    
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Введены некорретные данные");
        }
        }
    }
