using System;

class Program{
    static void Main(){
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double f;

        if (x < y){
            f = Math.Sin(x) + Math.Pow(Math.Cos(y), 2);
        }
        else if(x > y){
            f = Math.Sin(Math.Pow(y, 2)) + Math.Cos(y);
        }
        else{
            f = Math.Log10(x);
        }
        Console.WriteLine(f);
    }
}
