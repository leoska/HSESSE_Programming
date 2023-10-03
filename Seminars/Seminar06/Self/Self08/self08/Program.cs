namespace self08
{
    internal class Program
    {

        static void Initial(out double x0, out double z0, out double dx, out double dz, out int N, out int M)
        {

            Console.Write("Введите x0: ");

            double.TryParse(Console.ReadLine(), out double X0);
            Console.WriteLine();

            Console.Write("Введите z0: ");
            double.TryParse(Console.ReadLine(), out double Z0);
            Console.WriteLine();

            Console.Write("Введите dx: ");
            double.TryParse(Console.ReadLine(), out double DX);
            Console.WriteLine();

            Console.Write("Введите dz: ");
            double.TryParse(Console.ReadLine(), out double DZ);
            Console.WriteLine();

            Console.Write("Введите N: ");
            int.TryParse(Console.ReadLine(), out int n);
            Console.WriteLine();

            Console.Write("Введите M: ");
            int.TryParse(Console.ReadLine(), out int m);
            Console.WriteLine();

            x0 = X0;
            z0 = Z0;
            dx = DX;
            dz = DZ;
            N = n;
            M = m;
        }

        static void Func1(double x0, double z0, double stepX, double stepZ, int N, int M)
        {
            for (double i = x0, n = 0; n != N; i += stepX, n++)
            {
                for (double j = z0, m = 0; m != M ; j += stepZ, m++)
                {
                    if (j <= 0 || (i * i + j) < 0)
                    {
                        Console.WriteLine("Wrong input x or z");
                    }
                    else
                    {
                        double res = i * Math.Atan(i / Math.Pow(j, 0.5)) - Math.Log10(Math.Pow(i * i + j, 1.0 / 3)) + 1;
                        Console.WriteLine($"x = {i}, z = {j} \t func1 = {res}");
                    }

                }
            }
        }

        static void Func2(double x0, double z0, double stepX, double stepZ, int N, int M)
        {
            for (double i = x0, n = 0; n != N; i += stepX, n++)
            {
                for (double j = z0, m = 0; m != M; j += stepZ, m++)
                {
                    if (j < 0 || (i + j/i) == 0)
                    {
                        Console.WriteLine("Wrong input x or z");
                    }
                    else
                    {
                        double res = Math.Pow(Math.E, Math.Sqrt(j)) + Math.Pow(Math.Pow(i, 4), 1.0/3) * (1 + (i - i/j) / (i + i / j)) * (Math.Abs(Math.Sin(i)));
                        Console.WriteLine($"x = {i}, z = {j} \t func1 = {res}");
                    }

                }
            }
        }


        static void Main(string[] args)
        {

            bool flag = true;
            while (true)
            {
                if (!flag)
                {
                    break;
                }

                Console.WriteLine("1 - первая функция, 2 - вторая функция");
                Console.WriteLine("type 'exit' to close program");
                string command = Console.ReadLine();
                Console.WriteLine();

                switch (command)
                {
                    case "exit":
                        flag = false;
                        break;



                    case "1":

                        Initial(out double x01, out double z01, out double dx1, out double dz1, out int N1, out int M1);
                        Func1(x01, z01, dx1, dz1, N1, M1);
                        break;

                    case "2":
                        Initial(out double x02, out double z02, out double dx2, out double dz2, out int N2, out int M2);
                        Func2(x02, z02, dx2, dz2, N2, M2);
                        break;
                }
            }
        }
    }
}