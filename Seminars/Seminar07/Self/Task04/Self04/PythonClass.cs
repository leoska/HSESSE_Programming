using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self04
{
    internal class PythonClass
    {
        const string firstStr = "***";
        const string middleStr = "* *";  // введем константные поля для того, чтобы из них формировать строку (первую из firstStr, остальные из middleStr)
        
        public static void DrawPython(int n)
        {
            for (int i = 0; i < n; i++)        // будем отрисовывать каждую строку, с помощью n итераций цикла
            {

                if (i == 0)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(firstStr + " ");
                    }
                }


                else if (i == n - 1)
                {
                    for (int j = 0; j < n - 1; j++)
                    {
                        Console.Write(middleStr + "*");
                    }
                    Console.Write(middleStr);
                }


                else
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(middleStr + " ");
                    }
                }


                Console.WriteLine();
            }
        }
    }
}
