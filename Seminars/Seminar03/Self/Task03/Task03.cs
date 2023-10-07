using System.Threading.Tasks.Dataflow;
using System;

class LoL { 
    static void Main() {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        if (x * x + y * y < 2 * 2 && y > 0 || x * x + y * y <= 1 * 1 && y < 0) {
            Console.WriteLine("Точка принадлежит области");
        }
        else if (x * x + y * y == 1 * 1 && y < 0 || x * x + y * y == 2 * 2 && y > 0 || y == 0 && (x <= 2 && x >= 1 || x >= -2 && x <= -1)) {
            Console.WriteLine("Точка принадлежит границе");
        }
        else {
            Console.WriteLine("Точка не принадлежит области");
        }
    }
}
