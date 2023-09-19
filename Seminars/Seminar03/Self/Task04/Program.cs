using System;
using System.Runtime.CompilerServices;

namespace Task04
{
class Program
	{
		static void Main()
		{   
            // Запрос и считывание входных данных о координатах точки через консоль
            double x = 0;
            double y = 0;

            do
            {
                Console.Write("Введите X: ");
                while (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Неверный формат ввода!");
                    Console.Write("Введите вещественное число: ");
                }

                Console.Write("Введите Y: ");
                while (!double.TryParse(Console.ReadLine(), out y))
                {
                    Console.WriteLine("Неверный формат ввода!");
                    Console.Write("Введите вещественное число: ");
                }

                if (x == 0 && y == 0)
                {
                    Console.WriteLine($"Для вычисления значения переменной F, x и y не могут равняться нулю одновременно!");
                }
            } while (x == 0 && y == 0);
            

            // Вычисление значение F
            double F = (x - y) switch
            {
                < 0 => Math.Sin(x) + Math.Pow(Math.Cos(y), 2),
                0 => Math.Log(x),
                > 0 => Math.Sin(x * x) + Math.Cos(y),
                _ => 0
            };

            // Вывод значения F в консоль
            Console.WriteLine($"Значение перемнной F = {F}");
        }
	}
}