using System;

namespace HSE_1_Seminar1_Task6
{
    class Program
    {
        static void Main(string[] args)
        {

            //Task 6
            Console.WriteLine("Для подсчета, пожалуйста, введите значения");
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(a * a + b * b));
        }
    }
}
