
using System;
class Task2 {
  static void Main() {
    string[] FullName = Console.ReadLine().Split(' ');

    string Surname = FullName[0];
    string Name = FullName[1];
    string Patronymic = FullName[2];

    Console.WriteLine($"Фамилия: {Surname}");
    Console.WriteLine($"Имя: {Name}");
    Console.WriteLine($"Отчество: {Patronymic}");
  }
}
