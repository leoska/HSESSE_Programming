namespace Prak3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Считывание символа, введенного пользователем в консоль
            char a;

            do
            {
                Console.Write("Введите один символ: ");
            } while (!char.TryParse(Console.ReadLine(), out a));

            // Рассчет переменной F в зависимости от введенного символа a
            int F = a switch
            {
                >= '0' and <= '9' => 100,
                >= 'A' and <= 'Z' => 200,
                >= 'a' and <= 'z' => 300,
                _ => 400
            };

            // Вывод введенного символа a и значения переменной F
            Console.Write($"Символ: {a} | Ответ: {F}");
        }
    }
}