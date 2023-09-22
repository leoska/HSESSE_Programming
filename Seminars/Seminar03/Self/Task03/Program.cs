using System.Runtime.Intrinsics.X86;

namespace Task03;
class Program
{
    static void Main()
    {
        double x = Convert.ToDouble(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine());

        if (y < 0)
        {
            if (x * x + y * y < 1)
            {
                Console.WriteLine("Точка внутри заданной области.");
            }
            else if (x * x + y * y == 1)
            {
                Console.WriteLine("Точка лежит на границе области.");
            }
            else
            {
                Console.WriteLine("Точка не попала в область.");
            }    
        }
        else if (y > 0)
        {
            if (x * x + y * y < 4)
            {
                Console.WriteLine("Точка внутри заданной области.");
            }
            else if (x * x + y * y == 4)
            {
                Console.WriteLine("Точка лежит на границе области.");
            }
            else
            {
                Console.WriteLine("Точка не попала в область.");
            }
        }
        else
        {
            if (-1 < x && x < 1)
            {
                Console.WriteLine("Точка внутри заданной области.");
            }
            else if (-2 <= x && x <= -1 || 1 <= x && x <= 2)
            {
                Console.WriteLine("Точка лежит на границе области.");
            }
            else
            {
                Console.WriteLine("Точка не попала в область.");
            }
        }
               
    }
}