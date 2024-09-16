using System;
namespace task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count_int = 0;
            int count_double = 0;
            int count_else = 0;
            int n1;
            double n2;
            string n;
            do
            {
                n = Console.ReadLine();
                if (int.TryParse(n, out n1) && n != "0" && n != "-0")
                {
                    count_int += 1;
                }
                else if (double.TryParse(n, out n2) && n != "0" && n != "-0")
                {
                    count_double += 1;
                }
                else if (n != "0" && n != "-0")
                {
                    count_else += 1;
                }
            } while (n != "0" && n != "-0");
            Console.WriteLine($"целых - {count_int}");
            Console.WriteLine($"вещественных - {count_double}");
            Console.WriteLine($"нечисловых - {count_else}");
        }
    }
}

