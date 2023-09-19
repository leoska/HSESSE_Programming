using System;
 internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            switch (month)
            {
                case "January" or "Январь":
                    Console.WriteLine("1");
                    break;
                case "February" or "Ноябрь":
                    Console.WriteLine("2");
                    break;
                case "March" or "Март":
                    Console.WriteLine("3");
                    break;
                case "April" or "Апрель":
                    Console.WriteLine("4");
                    break;
                case "May" or "Май":
                    Console.WriteLine("5");
                    break;
                case "June" or "Июнь":
                    Console.WriteLine("6");
                    break;
                case "July" or "Июль":
                    Console.WriteLine("7");
                    break;
                case "August" or "Август":
                    Console.WriteLine("8");
                    break;
                case "September" or "Сентябрь":
                    Console.WriteLine("9");
                    break;
                case "October" or "Октябрь":
                    Console.WriteLine("10");
                    break;
                case "November" or "Ноябрь":
                    Console.WriteLine("11");
                    break;
                case "December" or "Декабрь":
                    Console.WriteLine("12");
                    break;
                default:
                    Console.WriteLine("В году такой год отсутствует.");
                    break;


            }
            Console.ReadKey();
        }
    }
