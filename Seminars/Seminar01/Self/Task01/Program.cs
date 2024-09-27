using System;

class Program
{
    public static void Main()
    {
        string name, surname, patronymic;
        name = Console.ReadLine();
        surname = Console.ReadLine();
        patronymic = Console.ReadLine();
        Console.WriteLine($"Имя:        {name}");
        Console.WriteLine($"Фамилия:    {surname}");
        Console.WriteLine($"Отчество:   {patronymic}");
    }
}