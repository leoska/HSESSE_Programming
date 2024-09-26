// Скорик Егор 239-2




class Program
{

    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.DarkCyan;
        Console.ForegroundColor = ConsoleColor.Blue;

        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Magenta;

        Console.WriteLine($"это консоль цвета {Console.BackgroundColor} очень даже ничего");

        while (true)
        {
            if (Console.ReadLine() == "exit")
                break;
        }

    }
}