using System.Threading.Tasks.Dataflow;
using System;

class LoL { 
    static void Main() {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int z = int.Parse(Console.ReadLine());

        Console.WriteLine((x < y ? (x < z ? x : z) : (y < z ? y : z)) + " " + (x > y ? (x < z ? x : (z > y ? z : y)) : (y < z ? y : (z > x ? z : x))) + " " + (x > y ? (x > z ? x : z) : (y > z ? y : z)));
    }
}
