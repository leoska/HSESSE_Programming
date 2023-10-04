using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self02
{
    internal class TriangleClass
    {
        public static void Triangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
