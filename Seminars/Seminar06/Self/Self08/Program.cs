using System;
internal class Program
{
    static void Main()
    {
        char rep;
        do
        {


            int number;
            do
            {
                Console.WriteLine("Выберите функцию, для которой построить таблицу значений");
                Console.Write("Введите номер функции: ");
                int.TryParse(Console.ReadLine(), out number);
                if (!(number == 1 || number == 2))
                {
                    Console.WriteLine("Введен некорректный номер, повторите ввод");
                }
            } while (!(number == 1 || number == 2));

            int n, m;
            double x0, dx, z0, dz;
            do
            {
                Console.Write("Введите N - кол-во выводимых значений X: ");
                int.TryParse(Console.ReadLine(), out n);
                Console.Write("Введите X0 - начальное значение X: ");
                double.TryParse(Console.ReadLine(), out x0);
                Console.Write("Введите dX - шаг X: ");
                double.TryParse(Console.ReadLine(), out dx);
                Console.Write("Введите M - кол-во выводимых значений Z: ");
                int.TryParse(Console.ReadLine(), out m);
                Console.Write("Введите Z0 - начальное значение Z: ");
                double.TryParse(Console.ReadLine(), out z0);
                Console.Write("Введите dZ - шаг Z: ");
                double.TryParse(Console.ReadLine(), out dz);
                if (n <= 0 || x0 <= 0 || dx <= 0 || m <= 0 || z0 <= 0 || dz <= 0)
                {
                    Console.WriteLine("Введены некорректные данные, повторите ввод");
                }
            } while (n <= 0 || x0 <= 0 || dx <= 0 || m <= 0 || z0 <= 0 || dz <= 0);
            double x = x0;// значения
            double z = z0;
            int n1 = n;  // указатели
            int m1 = m;
            if (number == 1)
            {
                while (n1 > 0)
                {
                    while (m1 > 0)
                    {
                        Console.WriteLine($"X={x}   Z={z}   F1(X,Z)={x * Math.Atan(x / Math.Sqrt(z)) - Math.Log(Math.Cbrt(x * x + z)) + 1}");
                        z += dz;
                        --m1;
                    }
                    x += dx;
                    --n1;
                    m1 = m;
                    z = z0;
                }

            }
            else
            {
                while (n1 > 0)
                {
                    while (m1 > 0)
                    {
                        Console.WriteLine($"X={x}   Z={z}   F2(X,Z)={Math.Pow(Math.E, Math.Sqrt(z)) + Math.Cbrt(x * x * x * x) * (1 + (x - z / x) / (x + z / x)) * Math.Abs(Math.Sin(x))}");
                        z += dz;
                        --m1;
                    }
                    x += dx;
                    --n1;
                    m1 = m;
                    z = z0;
                }

            }
            Console.WriteLine("Для повторения вычислений нажмите клавишу 'A'");
            char.TryParse(Console.ReadLine(), out rep);
        } while (rep == 'A' || rep == 'a');

    }
}