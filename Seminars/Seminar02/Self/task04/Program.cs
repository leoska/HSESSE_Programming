using System;
  internal class Program
    {
        static void Main()
        {
        try
        {
            char a = char.Parse(Console.ReadLine());
            Console.WriteLine((a >= 'А' && a <= 'я') ? "Это буква" : ((Char.IsDigit(a)) ? "Это цифра" : "Это ни буква, ни цифра"));
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Введены некорректные данные");
        }
        }
    }
