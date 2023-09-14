using System;
namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's your name? ");
            string user = Console.ReadLine();
            Console.WriteLine($"Hola, {user}!");
        }
    }
}
