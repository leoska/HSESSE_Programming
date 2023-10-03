using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        { /// Task04
            char a;
            string ans = "Ни цифра, ни буква";

            a = char.Parse(Console.ReadLine());

            ans = a >= '0' ? (a <= '9' ? "Это цифра" : "") : "";
            ans = a > 'а' ? (a < 'я' ? "Это буква" : "") : "";
            ans = a > 'А' ? (a < 'Я' ? "Это буква" : "") : "";

            Console.WriteLine(ans);
        }
    }
}
