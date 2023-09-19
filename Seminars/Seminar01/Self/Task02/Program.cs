using System;

class Program
{
    static void Main(string[] args)
    {
        // Запрос данных пользователя и их сохранение
        Console.Write("Введите вашу фамилию: ");
        string secondname = Console.ReadLine();

        Console.Write("Введите ваше имя: ");
        string firstname = Console.ReadLine();

        Console.Write("Введите ваше отчество: ");
        string surname = Console.ReadLine();

        // Вывод данных пользователя
        Console.WriteLine(secondname + " " + firstname + " " + surname);
    }
}
