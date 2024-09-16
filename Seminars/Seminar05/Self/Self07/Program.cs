using System;
internal class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            int n1 = 0;
            int a;
            bool f = true;
            string s = n.ToString();
            int le = s.Length;
            int q = le - 1;
            while (n != 0)
            {
                a = n % 10;
                n1 = n1 + (int)(Math.Pow(10, q)) * a;
                q -= 1;
                n = n / 10;
            }
            Console.WriteLine($"Перевернутое число - {n1}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Введены некорретные данные");
        }
    }
}