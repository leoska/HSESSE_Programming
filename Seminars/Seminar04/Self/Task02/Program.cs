class Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            string monthName = Console.ReadLine();
            
            int monthNumber = monthName.ToLower() switch
            {
                "январь" or "january" => 1,
                "февраль" or "february" => 2,
                "март" or "march" => 3,
                "апрель" or "april" => 4,
                "май" or "may" => 5,
                "июнь" or "june" => 6, 
                "июль" or "july" => 7,
                "август" or "august" => 8,
                "сентябрь" or "september" => 9,
                "октябрь" or "october" => 10,
                "ноябрь" or "novebmer" => 11,
                "декабрь" or "december" => 12,
                _ => -1
            };
            
            Console.WriteLine(monthNumber != -1 ? monthNumber : "В году такой месяц отсутствует");
        }
    }
}
