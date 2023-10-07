using System.Threading.Tasks.Dataflow;
using System;
using System.Xml.Serialization;

class LoL { 
    static void Main() {
        double DoubleRes = 0;
        for (int i = 1; i <= 500; ++i) {
            DoubleRes += (double)1 / (i * (i + 1) * (i + 2));
        }
        Console.WriteLine("Double result: " + DoubleRes);

        float FloatRes = 0;
        for (int i = 1; i <= 500; ++i) {
            FloatRes += (float)1 / (i * (i + 1) * (i + 2));
        }
        Console.WriteLine("Float result: " + FloatRes);

        decimal DecimalRes = 0;
        for (int i = 1; i <= 500; ++i) {
            DecimalRes += (decimal)1 / (i * (i + 1) * (i + 2));
        }
        Console.WriteLine("Decimal result: " + DecimalRes);

    }
}
