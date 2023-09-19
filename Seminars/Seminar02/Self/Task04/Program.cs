namespace HellowWorld
{
class Program
	{
		static void Main()
		{
            // Создание и считывание из консоли символьной переменной
			char a = char.Parse(Console.ReadLine());

            // Вывод чем является переменная в консоль
            Console.WriteLine($"{(('0' <= a && a <= '9') ? "Это цифра" : ((('a' <= a && a <= 'z') || ('A' <= a && a <= 'Z')) ? "Это буква" : "Это ни буква, ни цифра"))}");
        }
	}
}