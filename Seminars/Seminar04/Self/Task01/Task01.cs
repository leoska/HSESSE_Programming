using System.Threading.Tasks.Dataflow;
using System;

class LoL { 
    static void Main() {
        char x = char.Parse(Console.ReadLine());

        int f = x switch {
            >= '0' and <= '9' => 100,
            >= 'A' and <= 'Z' => 200,
            >= 'a' and <= 'z' => 300,
            _ => 400
        };
        Console.WriteLine(f);
    }
}
