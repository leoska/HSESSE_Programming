using System;
using System.Runtime.CompilerServices;

namespace Task04
{
class Program
	{
		static void Main()
		{   
            // Запрос и считывание входных данных о координатах точки через консоль
            double a = 0;

            Console.Write("Введите коэффициент квадратного уравнения a: ");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Неверный формат ввода!");
                Console.Write("Введите вещественное число: ");
            }

            
            double b = 0;

            Console.Write("Введите коэффициент квадратного уравнения b: ");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Неверный формат ввода!");
                Console.Write("Введите вещественное число: ");
            }

            double c = 0;

            Console.Write("Введите коэффициент квадратного уравнения c: ");
            while (!double.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Неверный формат ввода!");
                Console.Write("Введите вещественное число: ");
            }
            
            Console.Write("Решение уравнения "); 

            if (a != 0)
            {
               Console.Write($"{(a != 1 ? (a != -1 ? a : "-") : "")}x^2 "); 
            }
            if (b != 0)
            {
                Console.Write($"{(b < 0 ? (b == -1 ? "-" : "- ") : (a != 0 ? "+ " : ""))}{(Math.Abs(b) != 1 ? Math.Abs(b) : "")}x ");
            }
            if (c != 0)
            {
                Console.Write($"{(c < 0 ? '-' : '+')} {Math.Abs(c)} ");
            }
            Console.Write($"= 0 имеет ");
            
            if (a == 0)
            {
                Console.WriteLine("один корень:");
                Console.WriteLine($"x = {-c / b}");
            } else
            {
                double D = b * b - 4 * a * c;

                if (D >= 0)
                {
                    Console.WriteLine("два действительных корня:");
                    Console.WriteLine($"x1 = {(-b + Math.Sqrt(D)) / (2 * a)}");
                    Console.WriteLine($"x2 = {(-b - Math.Sqrt(D)) / (2 * a)}");
                } else
                {
                    double i_coeff = Math.Sqrt(Math.Abs(D)) / (2 * a);

                    Console.WriteLine("два комплексных корня:");
                    Console.Write($"x1 = {(b != 0 ? $"{-b / (2 * a)} " : "")}");
                    if (i_coeff != 0)
                    {
                        Console.WriteLine($"{(i_coeff > 0 ? (i_coeff != 1 ? '+' : "") : '-')}{(b == 0 ? "" : " ")}{(Math.Abs(i_coeff) != 1 ? Math.Abs(i_coeff) : "")}i");
                    }
                    Console.Write($"x2 = {(b != 0 ? $"{-b / (2 * a)} " : "")}");
                    if (i_coeff != 0)
                    {
                        Console.WriteLine($"{(i_coeff > 0 ? '-' : (i_coeff != 1 ? '+' : ""))}{(b == 0 ? "" : " ")}{(Math.Abs(i_coeff) != 1 ? Math.Abs(i_coeff) : "")}i");
                    }
                }
            }
        }
	}
}