using System;

namespace HSE_1_Seminar1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 5
            Console.WriteLine("Для подсчета, пожалуйста, введите значения");
            Console.Write("U = ");
            double U = Convert.ToDouble(Console.ReadLine());
            Console.Write("I = ");
            double I = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(U * U / I);
        }
    }
}
