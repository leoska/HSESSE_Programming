using System.Threading.Tasks.Dataflow;
using System;
using System.Xml.Serialization;

class LoL { 
    static void Main() {
        Console.WriteLine("A      B      C      F");
        bool A = false, B = false, C = false;
        do {
            do {
                do {
                    bool F = !(A | B & C) | A;
                    Console.WriteLine(A + " " + B + " " + C + " " + F);
                    C = !C;
                } while(C == true);
                B = !B;
            } while(B == true);
            A = !A;
        } while (A == true);
    }
}
