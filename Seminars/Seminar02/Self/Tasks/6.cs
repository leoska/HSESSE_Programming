using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {//Task06
            int a;
            a = int.Parse(Console.ReadLine());

            Console.WriteLine($"{Math.Abs(a / 100)} \n{Math.Abs(a % 100 / 10)} \n{Math.Abs(a % 10)}");
        }
    }
}