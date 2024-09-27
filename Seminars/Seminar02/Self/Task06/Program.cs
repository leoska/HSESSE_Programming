namespace HellowWorld
{
class Program
	{
		static void Main()
		{
            // Создание и считывание из консоли данных о радиусе круга и координатах точки
            int n = 0;
            
            do
            {
                Console.Write("Введите трехзначное число: ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 100 || n > 999);

            n = Math.Abs(n);
 
            // Вывод цифр числа
            Console.WriteLine(n / 100);
            Console.WriteLine(n / 10 % 10);
            Console.WriteLine(n % 10);
        }
	}
}