using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите код операции: ");
            int op;
            int.TryParse(Console.ReadLine(), out op);
            double A, B;
            Console.Write("Введите A: ");
            double.TryParse(Console.ReadLine(), out A);
            Console.Write("Введите B: ");
            double.TryParse(Console.ReadLine(), out B);
            if (A == 0 || B == 0 || op <= 0 || op >= 5)
            {
                Console.WriteLine("Введены некорректные данные");
            }
            else
            {
                switch (op)
                {
                    case 1:
                        Console.WriteLine($"{A} - {B} = {A - B}");
                        break;
                    case 2:
                        Console.WriteLine($"{A} + {B} = {A + B}");
                        break;
                    case 3:
                        Console.WriteLine($"{A} * {B} = {A * B}");
                        break;
                    case 4:
                        Console.WriteLine($"{A} / {B} = {A / B}");
                        break;


                }
            }
        }
    }
