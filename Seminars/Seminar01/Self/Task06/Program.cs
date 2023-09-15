// Считывание длин катетов.
double firstLeg;
do
{
    Console.Write("Введите длину первого катета: ");
} while (!double.TryParse(Console.ReadLine(), out firstLeg));
double secondLeg;
do
{
    Console.Write("Введите длину второго катета: ");
} while (!double.TryParse(Console.ReadLine(), out secondLeg));

// Расчёт и вывод длины гипотенузы.
double hypotenuse = Math.Sqrt(firstLeg * firstLeg + secondLeg * secondLeg);
Console.WriteLine($"Длина гипотенузы: {hypotenuse}");
