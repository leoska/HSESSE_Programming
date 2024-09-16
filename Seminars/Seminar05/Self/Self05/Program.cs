using System;
internal class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите значение K: ");
            int K = int.Parse(Console.ReadLine());
            double S = 0;
            int i;
            for (i = 1; i <= K; i++)
            {
                S = S + 1.0/ i;
            }
            Console.WriteLine($"Значение суммы - {S,0:f4}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Введены некорректные данные");
        }

    }
}