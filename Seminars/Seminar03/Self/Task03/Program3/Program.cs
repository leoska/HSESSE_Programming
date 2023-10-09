using System;

class Program{
    static void Main(){
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        double d = Math.Sqrt(Math.Pow(x, 2)+Math.Pow(y, 2));
        string message;

        if (y < 0){
            message = Check_cord(x, y, d, 1);
        }
        else{
            message = Check_cord(x, y, d, 2);
        }
        Console.WriteLine(message);
    }

    public static string Check_cord(double x, double y, double d, double radius){
        string message;
        if (d == radius){
            message = $"Точка ({x};{y}) попадает на границу области";
        }
        else if(d < radius){
            message = $"Точка ({x};{y}) попадает в область";
        }
        else{
            message = $"Точка ({x};{y}) не принадлежит точки области";
        }
        return message;
    }
}
