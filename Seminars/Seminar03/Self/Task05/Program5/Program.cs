using System;

class Program{
    static void Main(){
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double d = Math.Pow(b, 2) - 4*a*c;
        if (d < 0){
            Console.WriteLine("Нету корней");
        }
        else if(d > 0){
            double x1 = (-b-Math.Sqrt(d))/2*a;
            double x2 = (-b+Math.Sqrt(d))/2*a;
            Console.WriteLine("Урванение имеет 2 корня:");
            Console.WriteLine($"x1 = {x1}");
            Console.WriteLine($"x2 = {x2}");
        }
        else{
            double x = -b/2*a; 
            Console.WriteLine($"Уравнение имеет один корень: x = {x}");
        }
    }
}
