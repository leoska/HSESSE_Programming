using System;

class Program{
    static void Main(){
        string str = Console.ReadLine();
        int num = str switch{
            "Январь" or "January" => 1,
            "Февраль" or "Feburary" => 2,
            "Март" or "Mart" => 3,
            "Апрель" or "April" => 4,
            "Май" or "May" => 5,
            "Июнь" or "June" => 6,
            "Июль" or "Jule" => 7,
            "Август" or "August" => 8,
            "Сентябрь" or "September" => 9,
            "Октябрь" or "October" => 10,
            "Ноябрь" or "November" => 11,
            "Декабрь" or "December" => 12,
            _=>0
        };
        if(num != 0){
            Console.WriteLine(num);
        }
        else{
            Console.WriteLine("В году такой месяц отсутствует.");
        }
    }
}
