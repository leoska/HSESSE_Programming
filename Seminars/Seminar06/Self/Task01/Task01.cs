using System.Threading.Tasks.Dataflow;
using System;
using System.Xml.Serialization;


class LoL { 
    static void Main() {
        Console.WriteLine("p      q      F");
        bool p = false, q = false;
        do {
            do {
                bool f = !(p & q) & !(p | !q);
                Console.WriteLine(p + " " + q + " " + f);
                q = !q;
            } while(q == true);
            p = !p;
        } while (p == true);
    }
}
