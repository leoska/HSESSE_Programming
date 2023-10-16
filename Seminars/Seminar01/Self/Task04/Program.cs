using System;
class Programm
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.BackgroundColor = ConsoleColor.Cyan;
        string surname = Console.ReadLine();
        string name = Console.ReadLine();
        string patronymic = Console.ReadLine();
        Console.WriteLine("Фамилия: " + surname);
        Console.WriteLine("Имя: " + name);
        Console.WriteLine("Отчество: " + patronymic);
    }
}
