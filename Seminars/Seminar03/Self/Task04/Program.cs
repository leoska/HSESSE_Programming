namespace Task03;
class Program
{
    static void Main()
    {
        double x = Convert.ToDouble(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine());

        double f;
        if (x < y)
        {
            f = Math.Sin(x) + Math.Cos(y) * Math.Cos(y);
        }
        else if (x == y)
        {
            f = Math.Log(Math.Abs(x));
        }
        else
        {
            f = Math.Sin(x * x) + Math.Cos(y);
        }

        Console.WriteLine(f);
    }
}