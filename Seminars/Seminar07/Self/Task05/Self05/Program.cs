namespace Self05
{
    internal class Program
    {
        static int GetNOK(int n, int m)
        {
            for (int i = Math.Min(n, m); i <= n * m; i++)
            {
                if (i % n == 0 && i % m == 0)
                {
                    return i;
                   
                }
            }
            return 0;
        }

        static int GetNOD(int n, int m)
        {
            for (int i = Math.Min(n, m); i >= 1; i--)
            {

                if (n % i == 0 && m % i == 0)
                {
                    return i;
                }

            }
            return 1;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите числитель: ");
            int.TryParse(Console.ReadLine(), out int n);
            Console.WriteLine();

            Console.Write("Введите знаменатель: ");
            int.TryParse(Console.ReadLine(), out int m);
            Console.WriteLine();

            if (n > 0 && m > 0)
            {
                int nod = GetNOD(n, m);
                int nok = GetNOK(n, m);

                Console.WriteLine($"Результат: {n / nod}/{m / nod}");
                Console.WriteLine($"НОК: {nok}");
            }
        }
    }
}