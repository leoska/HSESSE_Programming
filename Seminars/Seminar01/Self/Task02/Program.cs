internal class Program
{
    public static void Main(String[] args)
    {
        string? surname = Console.ReadLine();
        string? name = Console.ReadLine();
        string? patronym = Console.ReadLine();

        Console.WriteLine($"{surname} {name} {patronym}");
    }
}