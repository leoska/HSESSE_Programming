using System.Threading.Tasks.Dataflow;
using System;

class LoL { 
    static void Main() {
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine(x / 100);
        Console.WriteLine(x / 10 % 10);
        Console.WriteLine(x % 10);
    }
}
