using System;

class LoL { 
    static void Main() {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.Black;

        string un = Console.ReadLine();
        
        Console.WriteLine("Привет, " + un + '!');
    }
}
