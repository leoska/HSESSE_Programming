using System;

class Program
{
    static void Main()
    {
        string surname = Console.ReadLine(), name = Console.ReadLine(), ot = Console.ReadLine();
        Console.WriteLine($"Фамилия: {surname}");
        Console.WriteLine($"Имя: {name}");
        Console.WriteLine($"Отчество: {ot}");

        // Task 2
        string ans = surname + " " + name + " " + ot;
        Console.WriteLine(ans);

        //Task 3
        Console.WriteLine($"Доброго времени суток, товарищ {ans}!");


    }
}
