
namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Какова длина одного катета? ");
            double.TryParse(Console.ReadLine(), out double a);
            double squareA = Math.Pow(a, 2);

            Console.Write("Какова длина второго катета? ");
            double.TryParse(Console.ReadLine(), out double b);
            double squareB = Math.Pow(b, 2);

            Console.Write($"Длина гипотенузы: {Math.Pow(squareA + squareB, 0.5)}");
        }
    }
}
