using System;
class Program
{
    static int gcd (int a, int b)
    {
        if (a == 0) {
            return b;
        }
        else {
            return gcd(b % a, a);
        }
    }
    static void Main()  
    {
        System.Console.Write("Введите числитель: ");
        int n = int.Parse(Console.ReadLine());
        System.Console.Write("Введите знаменатель: ");
        int m = int.Parse(Console.ReadLine());
        System.Console.WriteLine($"Результат: {n / gcd(n, m)}/{m / gcd(n, m)}");
        
    }
}
