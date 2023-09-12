// Your code here!
using System;

class Program{
    static void Main(){
        Console.BackgroundColor = ConsoleColor.Red;

        var last_name = Console.ReadLine();
        var first_name = Console.ReadLine();
        var patronymic = Console.ReadLine();

        Console.BackgroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Фамилия: {last_name}");
        Console.ResetColor();
        
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Имя: {0}", first_name);
        Console.ResetColor();

        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write("Отчество: " + patronymic);
    }
}
