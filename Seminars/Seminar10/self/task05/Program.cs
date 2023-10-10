using System.Diagnostics;
using System.Runtime.InteropServices;

namespace task05
{
    internal class Program
    {
        public static void Print_Array(int[] ar)
        {
            foreach (int x in ar)
            {
                Console.Write($"<{x}>");
            }
            Console.Write(Environment.NewLine);
        }
        static int[] RemoveBelowZeroEl(ref int[] A)
        {
            int[] removed = new int[A.Length];
            int[] ost = new int[A.Length];
            int qremoved = 0;
            int qost = 0;
            foreach (int x in A)
            {
                if (x < 0)
                {
                    removed[qremoved++] = x;
                }
                else
                {
                    ost[qost++] = x;
                }
            }
            Array.Resize(ref removed, qremoved);
            Array.Resize(ref ost, qost);
            A = ost;
            return removed;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            if (n != 0)
            {
                Console.WriteLine("Введите элементы");
            }
            for (int i = 0; i < n; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            Print_Array(A);
            Console.Write(Environment.NewLine);
            int[] ost = RemoveBelowZeroEl(ref A);
            Print_Array(A);
            Print_Array(ost);
        }
    }
}