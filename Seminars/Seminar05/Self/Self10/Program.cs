namespace Self10;
class Program
{
    static void Main()
    {
        Console.Write("Input value of x: ");
        double.TryParse(Console.ReadLine(), out double x);
        Console.WriteLine($"G({x}) is {G(x)}");
    }

    static double G(double x)
    {
        if (x <= 0.5)
        {
            return Math.Sin(Math.PI / 2);
        }
        else
        {
            return Math.Sin((x - 1) * Math.PI / 2);
        }
    }
}