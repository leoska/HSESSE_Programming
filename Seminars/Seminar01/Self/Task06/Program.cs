internal class Program
{
    public static void Main(String[] args)
    {
        while (true)
        {   
            Console.Write("Введите длину 1-го катета: ");
            Single.TryParse(Console.ReadLine(), out float leg1);

            Console.Write("Введите длину 2-го катета: ");
            Single.TryParse(Console.ReadLine(), out float leg2);

            if ((leg1 == 0) | (leg2 == 0))
            {
                Console.WriteLine("Пожалуйста, введите корректные данные (только цифры)");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Длина гипотенузы равна: {Math.Sqrt(Math.Pow(leg1, 2) + Math.Pow(leg2, 2))}");

                Console.ReadKey();

                break;
            }
        }
    }
}