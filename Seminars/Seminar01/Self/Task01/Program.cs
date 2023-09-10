namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            string? lastName = Console.ReadLine();
            string? firstName = Console.ReadLine();
            string? secondName = Console.ReadLine();

            Console.WriteLine($"Фамилия: {lastName}");
            Console.WriteLine($"Имя: {firstName}");
            Console.WriteLine($"Отчество: {secondName}");
        }
    }
}


