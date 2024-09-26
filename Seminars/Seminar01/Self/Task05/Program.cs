using System.Globalization;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите U (значение напряжения): ");
            double U = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Введите R (значение сопротивления): ");
            double R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"I (cила тока) = {U / R}");
            Console.WriteLine($"P (потребляемая мощность электрической цепи) = {U * U / R}");
        }
    }
}
