using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    public class Methods
    {
        public static void Triangle(int n)
        {
            if (n <= 0)
            {
                return;
            }
            else
            {
                string s = "";
                for (int i = 1; i <= n; i++)
                {
                    s += '*';
                    Console.WriteLine(s);
                }
            }
        }
    }
}
