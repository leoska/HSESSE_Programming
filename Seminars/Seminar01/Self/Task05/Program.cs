internal class Program
{
    public static void Main(String[] args)
    {
        Console.Write("Введите напряжение: ");
        int voltage = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите сопротивеление: ");
        int resistance = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Сила тока равна: {voltage / resistance}");
        Console.WriteLine($"Потребляемая мощность цепи равна: {Math.Pow(voltage, 2) / resistance}");
    }
}