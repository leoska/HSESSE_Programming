using System.Drawing;

namespace Task04
{
    class Program
    {
        public static System.ConsoleColor getRandomColor()
        {
            ConsoleColor[] colors = (ConsoleColor[]) ConsoleColor.GetValues(typeof(ConsoleColor));
            Random random = new Random();
            return colors[random.Next(0, colors.Length-1)];
        }

        public static void beutifulWriteLine(string str)
        {
            Console.BackgroundColor = getRandomColor();
            Console.ForegroundColor = getRandomColor();
            Console.WriteLine(str); 
        }

        public static void Main()
        {
            string? lastName = Console.ReadLine();
            string? firstName = Console.ReadLine();
            string? secondName = Console.ReadLine();

            beutifulWriteLine($"Фамилия: {lastName}");
            beutifulWriteLine($"Имя: {firstName}");
            beutifulWriteLine($"Отчество: {secondName}");

            // Restore the original console colors.
            Console.ResetColor();
        }
    }
}
