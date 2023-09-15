// Считывание напряжения.
double u;
do
{
    Console.Write("Введите значение напряжения: ");
} while (!double.TryParse(Console.ReadLine(), out u));

// Считывание сопротивления.
double r;
do
{
    Console.Write("Введите значение сопротивления: ");
} while (!double.TryParse(Console.ReadLine(), out r));

// Расчёт и вывод силы тока и мощности.
Console.WriteLine($"Сила тока: I = {u / r}");
Console.WriteLine($"Потребляемая мощность электрической цепи: P = {u * u / r}");