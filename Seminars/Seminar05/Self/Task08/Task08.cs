using System.Threading.Tasks.Dataflow;
using System;
using System.Xml.Serialization;

class LoL { 
    static void Main() {
        int x = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        if (Math.Pow(10, k - 1) > x) {
            Console.WriteLine("K не должно превышать количество разрядов исходного числа.");
        }
        else {
            while (Math.Pow(10, k) <= x) {
                x /= 10;
            }
            Console.WriteLine(x);
        }
    }
}
