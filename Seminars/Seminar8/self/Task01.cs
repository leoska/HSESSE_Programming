using System;
using System.Runtime.Serialization;
class asd {
    static double method_1() {
        double PI = 0;
        for (int i = 0; i <= 10000; ++i) {
            PI += Math.Pow(16, -i) * (4.0 / (8 * i + 1) - 2.0 / (8 * i + 4) - 1.0 / (8 * i+ 5) - 1.0 / (8 * i + 6));
        }
        return PI;
    }
    static double method_2() {
        double PI = 0;
        for (int k = 1; k <= 10000; ++k) {
            for (int m = 1; m <= k; ++m) {
                PI += 1.0 / Math.Pow(m * (k + 1), 3);
            }
        }
        return Math.Pow(360 * PI, 1.0 / 4);
    }
    
    static void Main(string[] args) {
        do {
            Console.WriteLine("Какой метод использовать? (1 или 2)");

            int num = int.Parse(Console.ReadLine());

            Console.WriteLine((num == 1 ? method_1() : method_2()));

        } while (Console.ReadKey().Key != ConsoleKey.Escape);
    }
} 
