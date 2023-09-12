namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            string? lastname = Console.ReadLine();
            string? name = Console.ReadLine();
            string? secondname = Console.ReadLine();

            Console.WriteLine($"Фамилия: {lastname}");
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Отчество: {secondname}");
        }
    }
}
