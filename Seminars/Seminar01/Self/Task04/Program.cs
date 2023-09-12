using System;

class Program
{
	const ConsoleColor mainBackgroundColor = ConsoleColor.DarkGray;
	const ConsoleColor outputBackgroundColor = ConsoleColor.Black;
	const ConsoleColor mainTextColor = ConsoleColor.DarkBlue;
	const ConsoleColor inputTextColor = ConsoleColor.Red;

	static void Main(string[] args)
	{
		Console.BackgroundColor = mainBackgroundColor;
		Console.Clear();

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
