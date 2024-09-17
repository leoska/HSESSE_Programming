internal class Program
{
    public static void Main(String[] args)
    {
        while (true)
        {
            Console.Write("Введите напряжение: ");
            Single.TryParse(Console.ReadLine(), out float voltage);

            Console.Write("Введите сопротивеление: ");
            Single.TryParse(Console.ReadLine(), out float resistance);
            
            if ((voltage == 0) | resistance == 0)
            {
                Console.WriteLine("Пожалуйста, введите корректные данные (только цифры)");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Сила тока равна: {voltage / resistance}");
                Console.WriteLine($"Потребляемая мощность цепи равна: {Math.Pow(voltage, 2) / resistance}");

                Console.ReadKey();

                break;
            }
        }
    }
}