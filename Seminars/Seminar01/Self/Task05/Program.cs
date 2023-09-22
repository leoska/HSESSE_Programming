using System;
namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Какое значениие напряжения? ");
            double.TryParse(Console.ReadLine(), out double U);

            Console.Write("А чему равно напряжение? ");
            double.TryParse(Console.ReadLine(), out double R);

            Console.WriteLine($"Сила тока в цепи равна {U / R}");
            Console.WriteLine($"Мощность электрической цепи равна {Math.Pow(U, 2) / R}");
        }
    }
}
