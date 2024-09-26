namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            string? name = Console.ReadLine();

            Console.WriteLine($"Привет, {name}!");
        }
    }
}
