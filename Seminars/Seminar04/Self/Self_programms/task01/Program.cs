using System;
    internal class Program
    {
        static void Main()
        {

            char a = char.Parse(Console.ReadLine());
            switch (a)
            {
                case >= '\u0030' and <= '\u0039':
                    Console.WriteLine("a = " + a + ", F = " + "100");
                    break;
                case >= '\u0041' and <= '\u005A':
                    Console.WriteLine("a = " + a + ", F = " + "200");
                    break;
                case >= '\u0061' and <= '\u007A':
                    Console.WriteLine("a = " + a + ", F = " + "300");
                    break;
                default:
                    Console.WriteLine("a = " + a + ", F = " + "400");
                    break;
            }
            Console.ReadKey();
        }
    }

