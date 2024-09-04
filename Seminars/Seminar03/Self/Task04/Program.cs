
namespace Task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double f;
            if (x < y) 
            {
                f = Math.Sin(x) + Math.Pow(Math.Cos(y), 2);
            }
            else if (x == y)
            {
                f = Math.Log(x, Math.E);
                
            }
            else
            {
                f = Math.Sin(x*x) + Math.Cos(y);
            }
            Console.WriteLine(f);
        }
    }
}