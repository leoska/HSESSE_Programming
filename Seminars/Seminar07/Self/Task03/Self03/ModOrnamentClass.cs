using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self03
{
    internal class ModOrnamentClass
    {
        public static void ModOrnament(int n, int m)
        {
            for (int i = 1; i <= n; i++)
            {
                string str = "*";

                for (int j = i; j > 1 ; j--)
                {
                    str += "*";
                }

                for (int s = 0; s < n - i; s++)
                {
                    str += " ";
                }

                for (int k = 0; k < m; k++)
                {
                    Console.Write(str);
                }
                Console.WriteLine();

            }
        }
    }
}
