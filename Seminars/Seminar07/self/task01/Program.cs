using System;
namespace task01
{
    internal class Program
    {
        static void Main()
        {

            try
            {
                Console.Write("Введите значение n: ");
                int n = int.Parse(Console.ReadLine());
                Methods.Triangle(n);
            }
            catch (FormatException)
            {
                Console.WriteLine("Введены некорректные данные");
            }
        }
    }
}
