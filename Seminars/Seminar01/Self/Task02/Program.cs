using System;
class Programm
{
    static void Main(string[] args)
    {
        string surname = Console.ReadLine();
        string name = Console.ReadLine();
        string patronymic = Console.ReadLine();
        Console.WriteLine($"Фамилия Имя Отчество: {surname} {name} {patronymic}");
    }
}