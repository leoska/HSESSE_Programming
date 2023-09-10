internal class Program
{
    public static void Main(String[] args)
    {
        Console.Write("Введите длину первого катета: ");
        float a = Convert.ToSingle(Console.ReadLine());
        Console.Write("Введите длину второго катета: ");
        float b = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine($"Длина гипотенузы равна: {Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))}");
    }
}