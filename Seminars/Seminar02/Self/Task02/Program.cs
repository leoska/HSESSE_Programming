namespace HellowWorld
{
class Program
	{
		static void Main()
		{
            // Создание и инициализация переменных
			double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            // Вывод сумм
            Console.WriteLine($"Сумма целых частей чисел {a} и {b} равна {(int)a + (int)b}");
            Console.WriteLine($"Сумма дробных частей чисел {a} и {b} равна {a - (int)a + b - (int)b}");
        }
	}
}