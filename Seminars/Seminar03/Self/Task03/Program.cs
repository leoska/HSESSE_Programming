using System;

namespace Task01
{
class Program
	{
		static void Main()
		{   
            // Запрос и считывание входных данных о координатах точки через консоль
            double x = 0;

            Console.Write("Введите координату X точки: ");
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Неверный формат ввода!");
                Console.Write("Введите вещественное число: ");
            }

            double y = 0;

            Console.Write("Введите координату Y точки: ");
            while (!double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Неверный формат ввода!");
                Console.Write("Введите вещественное число: ");
            }

            // Вывод сообщения о место нахождении точки относительно области в консоль
            if (((y > 0) && (x * x + y * y == 4)) || ((y < 0) && (x * x + y * y == 1)) || ((y == 0) && (Math.Abs(x) >= 1) && (Math.Abs(x) <= 2)))
            {
                Console.WriteLine($"Точка({x}, {y}) попала на границу области");
            } else if (((y > 0) && (x * x + y * y < 4)) || ((y <= 0) && (x * x + y * y < 1)))
            {
                Console.WriteLine($"Точка({x}, {y}) попала во внутрь области");
            } else
            {
                Console.WriteLine($"Точка({x}, {y}) не принадлежит области");
            }
        }
	}
}