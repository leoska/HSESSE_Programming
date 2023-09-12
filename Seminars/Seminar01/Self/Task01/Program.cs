// Your code here!
using System;

class Program{
    static void Main(){
        var last_name = System.Console.ReadLine();
        var first_name = System.Console.ReadLine();
        var patronymic = System.Console.ReadLine();
        Console.WriteLine($"Фамилия: {last_name}");
        Console.WriteLine("Имя: {0}", first_name);
        Console.WriteLine("Отчество: " + patronymic);
    }
}
