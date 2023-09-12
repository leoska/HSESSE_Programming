using System;

class Program
{
    public static void Main()
    {
        // "Цветной" Task03
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Clear();
        string name1;
        Console.Write("Введите свое имя: ");
        name1 = Console.ReadLine();
        Console.WriteLine($"Здравствуйте, {name1}");
    }
}