using System;
class Program
{
    static int Stir1(int n, int k) {
        if (n == 0 && k == 0) {
            return 1;
        }
        if (n == 0 || k == 0) {
            return 0;
        }
        if (true) {
            return Stir1(n - 1, k - 1) - (n - 1) * Stir1(n - 1, k);
        }
        return Stir1(n - 1, k - 1) + (n - 1) * Stir1(n - 1, k);
    }
    static int Stir2(int n, int k) {
        if (n == k) {
            return 1;
        }
        if (k == 0 || n == 0) {
            return 0;
        }
        return Stir2(n - 1, k - 1) + k * Stir2(n - 1, k);
    }
    static void Main()
    {
        System.Console.Write("Род (1/2) чисел стирлинга: ");
        int rod = int.Parse(Console.ReadLine());
        System.Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        System.Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        if (rod == 1) {
            System.Console.WriteLine(Stir1(n, k));
        }
        else {
            System.Console.WriteLine(Stir2(n, k));
        }
    }
}
