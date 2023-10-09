using System;

class Program{
    static void Main(){
        int n = int.Parse(Console.ReadLine());
        double l = double.Parse(Console.ReadLine());
        if(1<=n && n<11 && l>0){
            double s = (n*l*l)/(4*Math.Tan(Math.PI/n));
            Console.WriteLine(s);
        }
    }
}
