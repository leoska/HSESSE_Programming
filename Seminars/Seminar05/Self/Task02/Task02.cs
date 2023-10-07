using System.Threading.Tasks.Dataflow;
using System;
using System.Xml.Serialization;

class LoL { 
    static void Main() {
        string x = Console.ReadLine();
        int IsInt = 0, IsDouble = 0, IsStr = 0;
        while (x[0] != '0') {
            if (int.TryParse(x, out int buf1)) IsInt++;
            if (double.TryParse(x, out double buf2)) IsDouble++;
            else IsStr++;
            x = Console.ReadLine();
        }
        Console.WriteLine("int = " + IsInt);
        Console.WriteLine("double = " + IsDouble);
        Console.WriteLine("string = " + IsStr);
    }
}
