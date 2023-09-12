// Скорик Егор 239-2
class Program
{

    static void Main(string[] args)
    {
        Console.Write("Введите значение первого катета: ");
        double.TryParse(Console.ReadLine().Replace('.', ','), out double k1);
        Console.WriteLine();

        Console.Write("Введите значение второго катета: ");
        double.TryParse(Console.ReadLine().Replace('.', ','), out double k2);
        Console.WriteLine();

        if (k1 != 0 && k2 != 0)
        {
            Console.WriteLine($"Гипотенуза равна: {Math.Pow(k1 * k1 + k2 * k2, 0.5)}");
        }
        else
        {
            Console.WriteLine("Катеты не могут быть равны нулю");
        }



    }
}