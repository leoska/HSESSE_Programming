internal class Program
{
    public static void Main(String[] args)
    {
        while (true)
        {
            Console.Write("Введите фамилию: ");
            string? surname = Console.ReadLine();

            Console.Write("Введите имя: ");
            string? name = Console.ReadLine();

            Console.Write("Введите отчество: ");
            string? patronym = Console.ReadLine();

            if ((!surname.Any(char.IsDigit)) & (!name.Any(char.IsDigit)) & (!patronym.Any(char.IsDigit)))
            {
                Console.WriteLine();
                Console.WriteLine($"{surname} {name} {patronym}");

                Console.ReadKey();

                break;
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите корректное значение (Без цифр)");
                Console.WriteLine();
            }
        }
    }
}