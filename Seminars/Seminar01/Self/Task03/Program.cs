using System;
class Programm
{
    static void Main(string[] args)
    {
        Console.Write("Введите имя пользователя: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Здравствуйте, {name}!");
    }
}