﻿namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            string surname = Console.ReadLine();
            string name = Console.ReadLine();
            string fathersName = Console.ReadLine();

            Console.WriteLine($"Фамилия: {surname}");
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Отчество: {fathersName}");
        }
    }
}
