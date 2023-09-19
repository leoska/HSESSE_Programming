namespace HellowWorld
{
class Program
	{
		static void Main()
		{
            // Создание и инициализация переменных
			int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            // Меняем местами значения, чтобы было x <= y <= z
            int mn = (x < y && x < z) ? x : ((y < x && y < z) ? y : z);
            int mx = (x > y && x > z) ? x : ((y > x && y > z) ? y : z);
            int ar = x + y + z - mn - mx;

            x = mn;
            y = ar;
            z = mx;

            // Вывод переменных
            Console.WriteLine($"x = {x} y = {y} z = {z}");
        }
	}
}