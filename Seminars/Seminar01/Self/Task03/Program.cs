internal class Program
{
    public static void Main(String[] args)
    {
        while (true)
        {
            Console.Write("Введите имя: ");
            string? name = Console.ReadLine();

            if (!name.Any(char.IsDigit))
            {
                Console.WriteLine();
                Console.WriteLine($"Здравствуйте, {name}!");

                Console.ReadKey();

                break;
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите корректное значение имени (Без цифр)");
                Console.WriteLine();
            }
        }
    }
}