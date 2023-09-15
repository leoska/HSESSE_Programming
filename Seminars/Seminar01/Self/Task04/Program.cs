// Считывание ФИО.
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;
string? surname = Console.ReadLine();
string? name = Console.ReadLine();
string? lastName = Console.ReadLine();

// Вывод ФИО с изменением цвета текста и фона.
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine($"Фамилия: {surname}");
Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine($"Имя: {name}");
Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Отчество: {lastName}");
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;