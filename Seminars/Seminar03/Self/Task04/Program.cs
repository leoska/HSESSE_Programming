using System.Security.Cryptography.X509Certificates;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            const double eps = 1e-9;
            double F;

            if (Math.Abs(x - y) < eps)
            {
                F = Math.Log(Math.Abs(x));
            }
            else if (x < y){
                F = Math.Sin(x) + Math.Pow(Math.Cos(y), 2);
            }
            else
            {
                F = Math.Sin(x*x) + Math.Cos(y);
            }
            Console.WriteLine(F);
        }
    }
}
