using System.Text;

namespace Prak3
{
    internal class Program
    {
        static void Main()
        {
            // Считывание названия месяца, введенного пользователем, из консоли
            Console.Write("Введите название месяца / Enter month name: ");

            int monthNum = Console.ReadLine() switch {
                "January" or "Январь" => 1,
                "February" or "Февраль" => 2,
                "March" or "Март" => 3,
                "April" or "Апрель" => 4,
                "May" or "Май" => 5,
                "June" or "Июнь" => 6,
                "July" or "Июль" => 7,
                "August" or "Август" => 8,
                "September" or "Сентябрь" => 9,
                "October" or "Октябрь" => 10,
                "November" or "Ноябрь" => 11,
                "December" or "Декабрь" => 12,
                _ => 0
            };

            // Проверка корректности ввода и вывод результата в консоль
            if (monthNum != 0)
            {
                Console.WriteLine($"Номер месяца / Month number: {monthNum}");
            } else
            {
                Console.WriteLine("В году такой месяц отсутсвует / There is no such month in the year");
            }
        }
    }
}