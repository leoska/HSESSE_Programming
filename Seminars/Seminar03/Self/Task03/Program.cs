namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double distance = Math.Sqrt(x*x + y*y);
            const double eps = 1e-9;

            if (Math.Abs(distance - 1) < eps && y < eps)
            {
                Console.WriteLine("на границе");
            }
            else if (distance < 1 + eps)
            {
                Console.WriteLine("внутри области");
            }
            else if(Math.Abs(distance - 2) < eps && y > -eps || Math.Abs(y) < eps && (-2 - eps <= x && x <= -1 + eps || 1 - eps <= x && x <= 2 + eps))
            {
                Console.WriteLine("на границе");
            }
            else if (y > -eps && distance < 2 + eps)
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
