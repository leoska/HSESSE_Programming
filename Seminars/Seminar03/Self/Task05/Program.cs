namespace Task05;
class Program
{
    static void Main()
    {
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Уравнение: {a}*x^2 + {b}*x + {c} = 0");

        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("Решением уравнения является любое действительное число");
                }
                else
                {
                    Console.WriteLine("Решений нет");
                }
            }
            else
            {
                double x = (-c) / b;
                Console.WriteLine($"Уравнение имеет единственный корень х = {Math.Round(x, 3)}");
            }
        }
        else
        {
            double discriminant = b * b - 4 * a * c;
            if (discriminant < 0)
            {
                Console.WriteLine("Уравнение не имеет решений");
            }
            else if (discriminant > 0)
            {
                double x1 = (-b + Math.Pow(discriminant, 0.5)) / (2 * a);
                double x2 = (-b - Math.Pow(discriminant, 0.5)) / (2 * a);

                Console.WriteLine($"Уравнение имеет корни x1 = {Math.Round(x1, 3)} и х2 = {Math.Round(x2, 3)}");
            }
            else
            {
                double x = (-b) / (2 * a);

                Console.WriteLine($"Уравнение имеет два совпадающий корня, равных {Math.Round(x, 3)}");
            }
        }
    }
}