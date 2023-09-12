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
		Console.Write("Введите напряжение тока (U): ");
		Console.ForegroundColor = inputTextColor;
		double voltage = double.Parse(Console.ReadLine());

		Console.ForegroundColor = mainTextColor;
		Console.Write("Введите сопротивление тока (R): ");
		Console.ForegroundColor = inputTextColor;
		double resistance = double.Parse(Console.ReadLine());

        Console.ForegroundColor = mainTextColor;
        Console.Write("Сила тока: ");
        Console.ForegroundColor = formulaTextColor;
		Console.Write($"I = U/R = {voltage}/{resistance} = ");
        Console.ForegroundColor = answerTextColor;
        Console.WriteLine(voltage / resistance);

        Console.ForegroundColor = mainTextColor;
        Console.Write("Потребляемая мощность электрической цепи: ");
        Console.ForegroundColor = formulaTextColor;
		Console.Write($"P = U * U / R = {voltage} * {voltage} / {resistance} = ");
        Console.ForegroundColor = answerTextColor;
        Console.WriteLine(voltage * voltage / resistance);
 
		Console.ResetColor();
	}
}
