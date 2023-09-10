internal class Program
{
    public static void Main(String[] args)
    {
        Console.Write("Введите имя: ");
        string? name = Console.ReadLine();

        Console.WriteLine($"Здравствуйте, {name}!");
    }
}