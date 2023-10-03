namespace self09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double.TryParse(Console.ReadLine(), out double x);
            double.TryParse(Console.ReadLine(), out double y);
            bool G;

            double distanceFromCenter = Math.Pow(x * x + y * y, 0.5);

            if (x >= 0 && distanceFromCenter <= 2 && x >= y)
            {
                G = true;
            }
            else
            {
                G = false;
            }
            

            Console.WriteLine(G);
        }
    }
}