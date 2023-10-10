

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    public class Methods
    {
        public static void Triangle(int n, int m)
        {
            if (n <= 0)
            {
                return;
            }
            else
            {
                int qstar = 1;
                int qspace = n - 1;
                for (int i = 1; i <= n; i++)
                {
                    string s = "";
                    for (int k1 = 1; k1 <= qstar; k1++)
                    {
                        s += "*";
                    }
                    for (int k2 = 1; k2 <= qspace; k2++)
                    {
                        s += " ";
                    }
                    for (int k = 1; k <= m; k++)
                    {
                        if (k == m)
                        {
                            Console.WriteLine(s);
                        }
                        else
                        {
                            Console.Write(s);
                        }
                    }
                    ++qstar;
                    --qspace;
                }
            }
        }
    }
}

