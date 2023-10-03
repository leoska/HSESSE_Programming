using System;
using System.Runtime.Serialization.Formatters;

internal class Program
{
    static void Main()
    {
        try
        {
            char rep;
            do
            {


                Console.Write("Введите N: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Введите A: ");
                double a = double.Parse(Console.ReadLine());
                double q = a;
                double sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    sum = sum + 1 / q;
                    q = q * a;
                }
                Console.WriteLine($"Сумма = {sum}");
                double pr = 1;
                for (int i = 1; i <= n; i++)
                {
                    pr = pr * (a - i);
                }
                Console.WriteLine($"Произведение = {pr}");
                Console.WriteLine($"Для повтора вычислений нажмите клавишу 'A'");
                char.TryParse(Console.ReadLine(), out rep);
            } while (rep == 'A' || rep == 'a');


        }
        catch (FormatException)
        {
            Console.WriteLine("Введены некорректные данные");
        }
    }

}