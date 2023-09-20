using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, op1, op2, op3, a, b, c;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());

            op1 = z > x ? (y > x ? x : y) : (y > z ? z : y);
            op3 = z > x ? (y > z ? y : z) : (y > x ? y : x);
            op2 = x + y + z - op1 - op3;


            Console.WriteLine($"{op1} {op2} {op3}");
        }
    }
}