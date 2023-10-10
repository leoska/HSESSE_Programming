using System;
class Program
{
    static void Main()
    {
        string name1, name2, name3;
        name1 = Console.ReadLine();
        name2 = Console.ReadLine();
        name3 = Console.ReadLine();
        Console.WriteLine($"Фамилия: {name1}");
        Console.WriteLine($"Имя: {name2}");
        Console.WriteLine($"Отчество: {name3}");
    }
}