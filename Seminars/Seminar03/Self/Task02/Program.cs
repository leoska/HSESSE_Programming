namespace Task02;
class Program
{
    static void Main(string[] args)
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        if ((x * x + y * y == 1 && x >= -2 && x <= 2 && y >= 0) || (x * x + y * y == 4 && x >= -2 && x <= 2 && y >= 0) 
            || (((x <= -2 && x >= -1) || (x >= 1 && x <= 2)) && y == 0))
            Console.WriteLine("Точка находится на границе области.");
        else if (x * x + y * y < 4 && x * x + y * y > 1 && x >= -2 && x <= 2 && y >= 0) 
            Console.WriteLine("Точка внутри области.");
        else
            Console.WriteLine("Точка не принадлежит области.");
            
        
    }
}
