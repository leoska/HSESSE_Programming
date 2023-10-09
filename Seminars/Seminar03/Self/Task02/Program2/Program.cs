using System;

class Program{
    static void Main(){
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        if (y < 0){
            Console.WriteLine($"Точка ({x};{y}) не принадлежит точки области");
            return;
        }

        double d = Math.Sqrt(Math.Pow(x, 2)+Math.Pow(y, 2));

        if (d == 1 || d == 2){
            Console.WriteLine($"Точка ({x};{y}) попадает на границу области");
        }
        else if (d < 2 && d > 1){
            Console.WriteLine($"Точка ({x};{y}) попадает в область");
        }
        else{
            Console.WriteLine($"Точка ({x};{y}) не принадлежит точки области");
        }
    }
}
