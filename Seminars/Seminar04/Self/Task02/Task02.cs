using System.Threading.Tasks.Dataflow;
using System;

class LoL { 
    static void Main() {
        string x = Console.ReadLine();

        int f = x switch {
            "January" or "Январь" => 1,
            "February" or "Февраль" => 2,
            "March" or "Март" => 3,
            "April" or "Апрель" => 4,
            "May" or "Май" => 5,
            "June" or "Июнь" => 6,
            "July" or "Июль" => 7,
            "August" or "Август" => 8,
            "September" or "Сентябрь" => 9,
            "October" or "Октябрь" => 10,
            "November" or "Ноябрь" => 11,
            "December" or "Декабрь" => 12,

        };
        Console.WriteLine(f);
    }
}
