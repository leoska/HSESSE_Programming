using System;

class Program{
    static void Main(){
        Console.Write("Первый катет:");
        var a = float.Parse(Console.ReadLine());
        Console.Write("Второй катет:");
        var b = float.Parse(Console.ReadLine());

        var c = Math.Sqrt(a*a + b*b);

        Console.WriteLine($"Длина гипотенузы: {c}");
    }
}
