using System;

class Program
{
	// Константы цветов для различных групп текста в консоли
	const ConsoleColor mainBackgroundColor = ConsoleColor.DarkGray;
	const ConsoleColor outputBackgroundColor = ConsoleColor.Black;
	const ConsoleColor mainTextColor = ConsoleColor.DarkBlue;
	const ConsoleColor inputTextColor = ConsoleColor.Red;

	static void Main(string[] args)
	{
		// Смена цвета фона консоли
		Console.BackgroundColor = mainBackgroundColor;
		Console.Clear();

		// Запрос данных пользователя и их сохранение
		Console.ForegroundColor = mainTextColor;
		Console.Write("Введите вашу фамилию: ");
		Console.ForegroundColor = inputTextColor;
		string secondname = Console.ReadLine();

		Console.ForegroundColor = mainTextColor;
		Console.Write("Введите ваше имя: ");
		Console.ForegroundColor = inputTextColor;
		string firstname = Console.ReadLine();

		Console.ForegroundColor = mainTextColor;
		Console.Write("Введите ваше отчество: ");
		Console.ForegroundColor = inputTextColor;
		string surname = Console.ReadLine();

		// Разноцветный вывод данных пользователя (цвета от 10 до 15)
		Console.BackgroundColor = outputBackgroundColor;
		
		string name = secondname + " " + firstname + " " + surname;

		for (int i = 0; i < name.Length; i++) {
			Console.ForegroundColor = (ConsoleColor)(10 + i % 6);
			Console.Write(name[i]);
		}

		Console.WriteLine();

		Console.ResetColor();
	}
}
