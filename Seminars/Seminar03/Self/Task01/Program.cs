using System;

namespace Task01
{
class Program
	{
		static void Main()
		{   
            // Запрос и считывание входных данных о количестве сторон и их длинне от пользователя через консоль
            int n = 0;

            Console.Write("Введите количество сторон многоугольника (n > 3): ");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Неверный формат ввода!");
                Console.Write("Введите целое число большее трех: ");
            }

            double l = 0;

            Console.Write("Введите длинну стороны многоугольника (l > 0): ");
            while (!double.TryParse(Console.ReadLine(), out l))
            {
                Console.WriteLine("Неверный формат ввода!");
                Console.Write("Введите положительное вещественное число: ");
            }

            // Вывод площади заданного n-угольника со стороной l
            double S = (n * l * l) / (4 * Math.Tan(Math.PI / n));
            Console.WriteLine($"Площадь такого {n}-угольника со стороной {l} равна {S:.##}");
        }
	}
}