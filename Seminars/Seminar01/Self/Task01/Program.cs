internal class Program
{
    public static void Main(String[] args)
    {
        string? surname = Console.ReadLine();
        string? name = Console.ReadLine();
        string? patronym = Console.ReadLine();

        Console.WriteLine($"Фамилия: {surname}");
        Console.WriteLine($"Имя: {name}");
        Console.WriteLine($"Отчество: {patronym}");

        Console.ReadKey();
    }
}