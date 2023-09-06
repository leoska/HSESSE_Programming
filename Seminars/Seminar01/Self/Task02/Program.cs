using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите вашу фамилию: ");
        string secondname = Console.ReadLine();

        Console.Write("Введите ваше имя: ");
        string firstname = Console.ReadLine();

        Console.Write("Введите ваше отчество: ");
        string surname = Console.ReadLine();

        Console.WriteLine(secondname + " " + firstname + " " + surname);
    }
}
