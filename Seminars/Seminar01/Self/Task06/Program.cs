using System.Globalization;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину одного катета: ");
            double leg1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Введите длину другого катета: ");
            double leg2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Длина гипотенузы: {Math.Sqrt(leg1*leg1 + leg2*leg2)}");
        }
    }
}
