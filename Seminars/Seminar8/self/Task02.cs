using System;
using System.Runtime.Serialization;
class asd {
    public static bool Triangle(double x, double y, double z, out double p, out double s) {
        if (x + y <= z || x + z <= y || y + z <= x) {
            p = 0;
            s = 0;
            return false;
        }
        p = x + y + z;
        s = Math.Sqrt(p / 2 * (p / 2 - x) * (p / 2 - y) * (p / 2 - z));
        return true;
    }
    static void Main(string[] args) {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double z = double.Parse(Console.ReadLine());

        double p, s;
        if (Triangle(x, y, z, out p, out s)) Console.WriteLine($"P = {p}, S = {s}");
        else Console.WriteLine("Треугольник построить нельзя");
    }
} 
