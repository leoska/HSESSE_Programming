using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            string ans;
            x = Double.Parse(Console.ReadLine());
            y = Double.Parse(Console.ReadLine());
            z = Math.Sqrt(x * x + y * y);

            if (x >= 0 && y >= 0 || x <= 0 && y >= 0)
            {
                    switch (z)
                {
                    case > 2: ans = "�� �����������"; break;
                    case 1:
                    case 2: ans = "�� �������"; break;
                    default: ans = "�����������"; break;
                }
            }
            else
            {
                switch (z)
                {
                    case > 1: ans = "�� �����������"; break;
                    case 1: ans = "�� �������"; break;
                    default: ans = "�����������"; break;
                }
            }
            Console.WriteLine(ans);



        }
    }
}