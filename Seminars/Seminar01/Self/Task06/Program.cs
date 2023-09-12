using System;

class Program
{
	const ConsoleColor mainTextColor = ConsoleColor.White;
	const ConsoleColor inputTextColor = ConsoleColor.DarkRed;
    const ConsoleColor formulaTextColor = ConsoleColor.Cyan;
    const ConsoleColor answerTextColor = ConsoleColor.Yellow;

	static void Main(string[] args)
	{
        Console.Clear();

		Console.ForegroundColor = mainTextColor;
		Console.Write("Введите длинну первого катета a = ");
		Console.ForegroundColor = inputTextColor;
		double a = double.Parse(Console.ReadLine());

		Console.ForegroundColor = mainTextColor;
		Console.Write("Введите длинну второго катета b = ");
		Console.ForegroundColor = inputTextColor;
		double b = double.Parse(Console.ReadLine());

        Console.ForegroundColor = mainTextColor;
        Console.Write("В п/у треугольнике с катетами a и b гипотенуза с равна ");
        Console.ForegroundColor = formulaTextColor;
		Console.Write($"sqrt(a * a + b * b) = sqrt({a} * {a} + {b} * {b}) = ");
        Console.ForegroundColor = answerTextColor;
        Console.WriteLine(Math.Sqrt(a * a + b * b));
 
		Console.ResetColor();
	}
}
