
Console.Write("Введите 1 катет: ");
double k_1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите 2 катет: ");
double k_2 = Convert.ToDouble(Console.ReadLine());

double g = Math.Sqrt(k_1 * k_1 + k_2 * k_2); // Вычисление значения гипотенузы.

Console.WriteLine($"Гипотенуза = {g}");