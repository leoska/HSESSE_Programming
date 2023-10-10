using System.Security.Cryptography;

namespace task04_01
{
    internal class Program
    {
        static void SummIt(double a, double b, out int count, out int summ)
        {
            int a1 = (int)Math.Truncate(a);
            int b1 = (int)Math.Truncate(b);
            count = 0;
            summ = 0;
            for (int i = a1; i <= b1; i++)
            {
                if (i <= 0)
                {
                    continue;
                }
                else
                {
                    string s = i.ToString();
                    if (s.Contains("0"))
                    {
                        count += 1;
                        summ += i;
                    }
                }
            }
        }
        static void TotalSumm(double a, double b, out int summ)
        {
            int a1 = (int)Math.Truncate(a);
            int b1 = (int)Math.Truncate(b);
            summ = 0;
            for (int i = a1; i <= b1; i++)
            {
                if (i <= 0)
                {
                    continue;
                }
                else
                {
                    summ += i;
                }
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите A и B");
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                TotalSumm(a, b, out int summ1);
                SummIt(a, b, out int count, out int summ2);
                Console.WriteLine($"Значение вычислений - {Math.Abs(summ1-summ2)}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Введены некорректные значения");
            }
        }
    }
}