
Console.Write("Введите значение напряжения: ");
double u = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение сопротивления: ");
double r = Convert.ToDouble(Console.ReadLine());

double i = u / r; // Сила тока.
double p = u * u / r; // Потребляемая мощность электрической цепи.

Console.WriteLine($"Сила тока = {i}");
Console.WriteLine($"Потребляемая мощность электрической цепи = {p}");