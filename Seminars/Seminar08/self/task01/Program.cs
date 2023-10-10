using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace task01
{
    internal class Program
    {
        static double[] P1()
        {
            double a = 0;
            double b = 0;
            double k = 0;
            double sum = 0;
            double sum1 = 0;
            do
            {
                k++;
                double sum2 = 0;
                sum1 = sum1 + 1 / k;
                sum2 = sum1 * 1 / (Math.Pow(k + 1, 3));
                sum = sum + sum2;
                a = b;
                b = sum;
            } while (b - a > double.Epsilon);
            double[] ar = new double[2] { Math.Pow(360 * sum, 1.0 / 4), k };
            return ar;
        }
        static double[] P2()
        {
            double a = 0;
            double b = 0;
            double i = 0;
            double sum = 0;
            do
            {
                sum = sum + Math.Pow(16, -i) * (4 / (8 * i + 1) - 2 / (8 * i + 4) - 1 / (8 * i + 5) - 1 / (8 * i + 6));
                a = b;
                b = sum;
                i++;
            } while (b - a > double.Epsilon);
            double[] ar = new double[2] { sum, i };
            return ar;
        }
        static void Main(string[] args)
        {
            do
            {
                try
                {

                    Console.Write("Введите номер выбранного метода: ");
                    int n = int.Parse(Console.ReadLine());
                    if (n == 1)
                    {
                        double[] arg = new double[2];
                        arg = P1();
                        Console.WriteLine($"Приближенное значение = {arg[0]}, кол-во итераций = {arg[1]}");
                    }
                    else if (n == 2)
                    {
                        double[] arg = new double[2];
                        arg = P2();
                        Console.WriteLine($"Приближенное значение = {arg[0]}, кол-во итераций = {arg[1]}");
                    }
                    else
                    {
                        Console.WriteLine("Введены некорретные данные");
                    }
                    Console.WriteLine("Для выхода из программы нажмите Escape");

                }
                catch (FormatException)
                {
                    Console.WriteLine("Введены некорректные данные");
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}