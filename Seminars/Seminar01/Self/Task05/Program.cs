using System;
class Program
{
    static void Main(string[] args)
    {
        float u, r;
        Console.Write("Значение напряжения: ");
        u = float.Parse(Console.ReadLine());
        Console.Write("Значение сопротивления: ");
        r = float.Parse(Console.ReadLine());
        Console.WriteLine($"Сила тока равна {u / r}");
        Console.WriteLine($"Потребляемая мощность электрической цепи равна {u * u / r}");
    }


}
