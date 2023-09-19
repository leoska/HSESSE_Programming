namespace HellowWorld
{
class Program
	{
		static void Main()
		{
            // Создание и считывание из консоли данных о радиусе круга и координатах точки
            double r = 0;
            
            do
            {
                Console.Write("Введите радиус круга (R > 0): ");
            } while (!double.TryParse(Console.ReadLine(), out r) || r <= 0);

            double x = 0;
            
            do
            {
                Console.Write("Введите x-координату точки: ");
            } while (!double.TryParse(Console.ReadLine(), out x));

            double y = 0;
            
            do
            {
                Console.Write("Введите y-координату точки: ");
            } while (!double.TryParse(Console.ReadLine(), out y));

            // Вывод где лежит точка
            Console.WriteLine($"{(x * x + y * y <= r * r ? "Точка внутри круга!" : "Точка вне круга!")}");
        }
	}
}