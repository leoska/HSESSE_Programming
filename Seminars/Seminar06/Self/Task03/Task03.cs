using System.Threading.Tasks.Dataflow;
using System;
using System.Xml.Serialization;


class LoL { 
    static bool Check(string c) {
        return c[0] != c[1] && c[0] != c[2] && c[0] != c[3] && c[1] != c[2] && c[1] != c[3] && c[2] != c[3]; 
    }
    static void Main() {
        for (int i = 2000; i <= 3000; ++i) {
            if (Check(i.ToString())) {
                Console.WriteLine(i);
            }
        }
    }
}
