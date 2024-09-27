namespace HellowWorld
{
class Program
	{
		static void Main()
		{
            // Создание и инициализация переменных
			int a = 4;
            double b = 4d;
            char c = 'c';

            // Вывод значения переменных
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            // Вывод типов переменных
            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());
            Console.WriteLine(c.GetType());
        }
	}
}