using System.Threading.Tasks.Dataflow;
using System;

class LoL { 
    static void Main() {
        for (int i = 0; i <= 50; i++) {
            if (i == 20) continue;
            Console.Write("Число " + i);
            if (i % 2 == 0 && i % 3 == 0) {
                Console.WriteLine(" кратно 2 и 3");
            }
            else {
                Console.WriteLine(" не соответствует условию");
            }
        }
    }
}
