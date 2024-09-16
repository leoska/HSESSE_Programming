using System;
internal class Program
{
    static void Main()
    {
        double a = 0.1; // указатель
        while (a<1.8)
        {
            Console.WriteLine($"Значение функции в точке {a,0:f1} - {(a + 1) / (Math.Pow(a, 5) + 1) + Math.Log(a + 1),0:f2}");
            a += 0.1;
        }
        Console.WriteLine("Характерная точка первого графика функции пройдена");
        Console.WriteLine("");
        a =0.1;
        while (a < 1.6)
        {
            Console.WriteLine($"Значение функции в точке {a,0:f1} - {a-Math.Pow(Math.E, -a)*Math.Cos(a),0:f2}");
            a += 0.1;
        }
        Console.WriteLine("Характерная точка второго графика функции пройдена");
        Console.WriteLine("");
        a = 0.1;
        while (a < 1.09)
        {
            Console.WriteLine($"Значение первой функции в точке {a,0:f1} - {0.1*a*a*a-a*a+0.1,0:f2}");
            Console.WriteLine($"Значение второй функции в точке {a,0:f1} - {(a-2)*Math.Cbrt(a*a),0:f2}");
            a += 0.1;
        }
        Console.WriteLine("Характерная точка пары последних графиков функций пройдена");
    }
}
