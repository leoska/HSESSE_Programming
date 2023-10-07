using System.Threading.Tasks.Dataflow;
using System;
using System.Xml.Serialization;


class LoL { 
    static void Main() {
        int N = int.Parse(Console.ReadLine());
        int A = int.Parse(Console.ReadLine());

        double S = 0, P = 1;
        for (int i = 1; i <= N; ++i) {
            double PowA = 1;
            for (int j = 1; j <= i; ++j) {
                PowA *= A;
            }
            S += (double)1 / PowA;
            P *= (A - i);
        }
        Console.WriteLine(S);
        Console.WriteLine(P);
    }
}
