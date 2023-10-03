using System;
internal class Program
{
    static void Main()
    {
        char rep;
        do
        {
            double x;
            int n;
            do
            {


                Console.Write("Enter x: ");
                double.TryParse(Console.ReadLine(), out x);
                Console.Write("Enter n: ");
                int.TryParse(Console.ReadLine(), out n);
                if (n < 1 || x <= 0 || n > 20)
                {
                    Console.WriteLine("Wrong input");
                    Console.WriteLine("Enter correct numbers");
                }
            } while (n < 1 || x <= 0 || n > 20);
            double sum = 0;
            for (int k = 1; k <= n; k++)
            {
                sum = sum + Math.Abs(x - k) * Math.Cos(Math.Cbrt(k) * x / 2);
            }
            double res = (Math.Log(x) - 2 / 9) * sum;
            Console.WriteLine($"Вычисленное значение = {res:F3}");
            Console.WriteLine("Для повторения вычислений нажмите клавишу 'A'");
            char.TryParse(Console.ReadLine(), out rep);
        } while (rep == 'A' || rep == 'a');

    }
}