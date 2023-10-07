using System.Threading.Tasks.Dataflow;
using System;

class LoL { 
    static void Main() {
        char x = char.Parse(Console.ReadLine());

        Console.WriteLine(x >= '0' && x <= '9' ? "Это цифра" : (x >= 'а' && x <= 'я' || x >= 'А' && x <= 'Я' ? "Это буква" : "Это ни буква, ни цифра"));
    }
}
