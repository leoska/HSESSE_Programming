internal class Program
{
    public static void Main(String[] args)
    {
        if (Console.BackgroundColor == ConsoleColor.Black)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Cyan;
        }

        string? surname = Console.ReadLine();
        string? name = Console.ReadLine();
        string? patronym = Console.ReadLine();

        Console.WriteLine($"Фамилия: {surname}");
        Console.WriteLine($"Имя: {name}");
        Console.WriteLine($"Отчество: {patronym}");

        Console.ReadKey();
    }
}