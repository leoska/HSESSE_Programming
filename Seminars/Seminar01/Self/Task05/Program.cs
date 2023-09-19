using System;

class Program
{
    // Константы цветов для различных групп текста в консоли
	const ConsoleColor mainTextColor = ConsoleColor.White;
	const ConsoleColor inputTextColor = ConsoleColor.DarkRed;
    const ConsoleColor formulaTextColor = ConsoleColor.Cyan;
    const ConsoleColor answerTextColor = ConsoleColor.Yellow;

	static void Main(string[] args)
	{
        Console.Clear();

        // Запрос и сохранение ввода напряжения и сопротивления тока от пользователя
		Console.ForegroundColor = mainTextColor;
		Console.Write("Введите напряжение тока (U): ");
		Console.ForegroundColor = inputTextColor;
		double voltage = double.Parse(Console.ReadLine());

		Console.ForegroundColor = mainTextColor;
		Console.Write("Введите сопротивление тока (R): ");
		Console.ForegroundColor = inputTextColor;
		double resistance = double.Parse(Console.ReadLine());

        // Подсчёт силы тока и вывод её формулы и значения
        Console.ForegroundColor = mainTextColor;
        Console.Write("Сила тока: ");
        Console.ForegroundColor = formulaTextColor;
		Console.Write($"I = U/R = {voltage}/{resistance} = ");
        Console.ForegroundColor = answerTextColor;
        Console.WriteLine(voltage / resistance);

        // Подсчёт потребляемой мощности электрической цепи и вывод её формулы и значения
        Console.ForegroundColor = mainTextColor;
        Console.Write("Потребляемая мощность электрической цепи: ");
        Console.ForegroundColor = formulaTextColor;
		Console.Write($"P = U * U / R = {voltage} * {voltage} / {resistance} = ");
        Console.ForegroundColor = answerTextColor;
        Console.WriteLine(voltage * voltage / resistance);
 
		Console.ResetColor();
	}
}
