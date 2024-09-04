namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int result = 0;
            switch (month)
            {
                case "January" or "Январь":
                    result = 1; break;
                case "February" or "Февраль":
                    result = 2; break;
                case "March" or "Март":
                    result = 3; break;
                case "April" or "Апрель":
                    result = 4; break;
                case "May" or "Май":
                    result = 5; break;
                case "June" or "Июнь":
                    result = 6; break;
                case "July" or "Июль":
                    result = 7; break;
                case "August" or "Август":
                    result = 8; break;
                case "September" or "Сентябрь":
                    result = 9; break;
                case "October" or "Октябрь":
                    result = 10; break;
                case "November" or "Ноябрь":
                    result = 11; break;
                case "December" or "Декабрь":
                    result = 12; break;
                default:
                    Console.WriteLine("В году такой месяц отсутствует."); break;

            }
            if (result != 0)
            {
                Console.WriteLine(result);
            }
        }
    }
}