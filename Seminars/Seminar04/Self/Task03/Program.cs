using System;

namespace Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            int op;
            Console.Write("Введите код операции: ");
            int.TryParse(Console.ReadLine(), out op);
            Console.Write("Введите A: ");
            double.TryParse(Console.ReadLine(), out a);
            Console.Write("Введите B: ");
            double.TryParse(Console.ReadLine(), out b);
            double res;
            if (op >= 1 && op <= 4 && b != 0)
            {
                switch (op)
                {
                    case 1:
                        Console.WriteLine($"{a} + {b} = {a + b}"); break;
                    case 2:
                        Console.WriteLine($"{a} - {b} = {a - b}"); break;
                    case 3:
                        Console.WriteLine($"{a} * {b} = {a * b}"); break;
                    case 4:
                        Console.WriteLine($"{a} / {b} = {a / b}"); break;
                    default:
                        Console.WriteLine("Данные некорректны."); break;
                }
            }
            else
            {
                Console.WriteLine("Данные некорректны.");
            }
        }
    }
}