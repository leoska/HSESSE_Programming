using System;
internal class Programm
{
    static void Main()
    {
        try
        {
            Console.Write("Введите A: ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Введите N: ");
            int N = int.Parse(Console.ReadLine());
            double rass = A / N;  // длина маленьких областей
            int q = 0;  //  Счетчик
            double S = 0;  // Площадь
            double n = 0;  // Указатель
                while (q!=N)
            {
                q += 1;
                n += rass;
                S = S + (n * n * rass);
            }
            Console.WriteLine($"Значение площади: {S}");

        }
        catch (FormatException ex)
        {
            Console.WriteLine("Введены некорректные данные");
        }
    }
}