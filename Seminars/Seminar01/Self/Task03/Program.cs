using System.Reflection.Metadata;
using System;

class Program
{
    static void Main(string[] args)
    {   
        // Запрос имени пользователя и его сохрание
        Console.Write("Введите ваше имя пользователя: ");
        string username = Console.ReadLine();

        // Привествие пользователя
        Console.WriteLine("Здравствуйте, " + username + "!");
    }
}
