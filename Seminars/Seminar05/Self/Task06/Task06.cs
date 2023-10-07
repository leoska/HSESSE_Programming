using System.Threading.Tasks.Dataflow;
using System;
using System.Xml.Serialization;

class LoL { 
    static void Main() {
        for (int i = 100; i <= 999; ++i) {
            if (i / 100 == i / 10 % 10 && i / 100 == i % 10 && i / 10 % 10 == i % 10) {
                Console.WriteLine(i);
            }
        }
    }
}
