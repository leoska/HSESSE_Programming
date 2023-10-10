using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    internal class Methods
    {
        public static void Print_Array(double[] ar)
        {
            foreach (double x in ar)
            {
                Console.Write($"<{x}>");
            }
            Console.Write(Environment.NewLine);
        }
        public static void Print_Array(int[] ar)
        {
            foreach (int x in ar)
            {
                Console.Write($"<{x}>");
            }
            Console.Write(Environment.NewLine);
        }
        public static void Fill_Array(int n, Random rnd, out double[] A)
        {
            A = new double[n];
            for (int i = 0; i < n; i++)
            {
                A[i] = rnd.NextDouble() * ((double)float.MaxValue - (double)float.MinValue) + (double)float.MinValue;
            }
        }
        public static void Fill_Array(int n, out int[] A)
        {
            A = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите целое число");
                A[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void Fill_Array(int n, out double[] A)
        {
            A = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите вещественное число");
                A[i] = Math.Round(double.Parse(Console.ReadLine()), 3);
            }
        }
        public static void Fill_Array(int n, Random rnd, out int[] A)
        {
            A = new int[n];
            for (int i = 0; i < n; i++)
            {
                A[i] = rnd.Next(int.MinValue, int.MaxValue);
            }
        }
    }
}
