using System;
class asd {
    static void Triangle(ref int n) {
        for (int i = 1; i <= n; ++i) {
            for (int j = 1; j <= i; ++j) {
                Console.Write('*');
            }
            Console.WriteLine();
        }
    }
    static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        Triangle(ref n);
    }
}
