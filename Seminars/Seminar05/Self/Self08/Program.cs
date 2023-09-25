using System;
internal class Program
{
    static void Main()
    {
        try
        {


            Console.Write("Введите число - ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите число старших разрядов - ");
            int k = int.Parse(Console.ReadLine());
            string s = n.ToString();
            int le = s.Length;
            if (k>le)
            {
                Console.WriteLine("Введенной кол-во старших разрядов больше длины числа");
                return;
            }
            int n1 = n / (int)(Math.Pow(10, (le-k)));
            Console.WriteLine($"Полученное число - {n1}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Введены некорректные данные");
        }
    }
}
