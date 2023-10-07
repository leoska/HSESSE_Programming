using System.Threading.Tasks.Dataflow;
using System;
using System.Xml.Serialization;

class LoL { 
    static void Main() {
        int x = int.Parse(Console.ReadLine());
        while (x % 10 == 0) {
            x /= 10;
        }
        while (x > 0) {
            Console.Write(x % 10);
            x /= 10;
        }
    }
}
