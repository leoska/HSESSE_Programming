using System.Threading.Tasks.Dataflow;
using System;
using System.Xml.Serialization;

class LoL { 
    static void Main() {
        int q = int.Parse(Console.ReadLine());
        
        for (int n = 1; n <= q; n++) {
            int res = 0;
            for (int k = 1; k <= n; k++) {
                int fact = 1;
                for (int f = 1; f <= k; f++) {
                    fact *= f;
                }
                res += fact;
            }
            Console.WriteLine("S(" + n + ") = " + res);
        }
    }
}
