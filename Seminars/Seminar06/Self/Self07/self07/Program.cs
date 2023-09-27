namespace self07
{
    internal class Program
    {

        static void Func(double x, int n)
        {
            double res = (Math.Log(x) - 2.0 / 9);

            double subres = 0;

            for (int k = 1; k <= n; k++)
            {
                subres += Math.Abs(x - k) * Math.Cos((Math.Pow(k, 1.0 / 3) * x) / 2.0);

            }

            Console.WriteLine(res * subres);
        }
        static void Main(string[] args)
        {
            double x;
            int n;

            while (true)
            {
                Console.WriteLine("Введите x и n");
                double.TryParse(Console.ReadLine(), out double X);
                int.TryParse(Console.ReadLine(), out int N);
                Console.WriteLine();


                if (1 <= N && N <= 20 && X > 0)
                {
                    Func(X, N);

                    string command = Console.ReadLine();

                    switch (command)
                    {
                        case "repeat":
                            continue;

                        default:
                            return;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }            

            }
        }
    }
}