namespace Task02;
class Program
{
    static void Main()
    {
        double x = Convert.ToDouble(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine());

        if (y > 0 && (x * x + y * y > 1) && (x * x + y * y < 4))
        {
            Console.WriteLine("Точка внутри заданной области");
        }
        else if ((y == 0) && ((-2 <= x && x <= -1) || (1 <= x && x <= 2)) ||
            (y >= 0 && (x * x + y * y == 1 || x * x + y * y == 2)))
        {
            Console.WriteLine("Точка лежит на границе области");
        }
        else
        {
            Console.WriteLine("Точка не попала в заданную область");
        }
    }
}