namespace self03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите A: ");
            if (!double.TryParse(Console.ReadLine(), out double A))
            {
                Console.WriteLine("ошибка");
                return;
            }
            Console.WriteLine();

            Console.Write("Введите N: ");
            if (!int.TryParse(Console.ReadLine(), out int N))
            {
                Console.WriteLine("ошибка");
                return;
            }
            Console.WriteLine();

            double rectLen = (double)(A / N);

            double area = 0;

            int i = 0;

            while (i * rectLen <= A)
            {
                double rectHeight = Math.Pow(i * rectLen, 2);
                area += rectLen * rectHeight;

                i++;
            }

            Console.WriteLine(area);

        }
    }
}