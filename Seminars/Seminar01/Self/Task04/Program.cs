using System;
class Task1 {
  static void Main() {

    ConsoleColor[] colors = (ConsoleColor[]) ConsoleColor.GetValues(typeof(ConsoleColor));
    Console.BackgroundColor = colors[2];
    Console.WriteLine("Зелёная консоль");

    string Surname  = Console.ReadLine();
    string Name = Console.ReadLine();
    string Patronymic = Console.ReadLine();

    Console.WriteLine($"Фамилия: {Surname}");
    Console.WriteLine($"Имя: {Name}");
    Console.WriteLine($"Отчество: {Patronymic}");


  }
}
