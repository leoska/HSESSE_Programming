namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            const double eps = 1e-9;

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if (y < eps && (-2 - eps <= x && x <= -1 + eps || 1 - eps <= x && x <= 2 + eps))
            {
                Console.WriteLine("на границе");
            }
            else if (y < 0)
            {
                Console.WriteLine("вне области");
            }
            else if (Math.Abs(Math.Sqrt(x * x + y * y) - 1) < eps || Math.Abs(Math.Sqrt(x * x + y * y) - 2) < eps)
            {
                Console.WriteLine("на границе");
            }
            else if (1 - eps <= Math.Sqrt(x * x + y * y) && Math.Sqrt(x * x + y * y) <= 2 + eps)
            {
                Console.WriteLine("внутри области");
            }
            else
            {
                Console.WriteLine("вне области");
            }
        }
    }
}
