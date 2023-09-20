﻿using System;
class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        int res = s switch {
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
            _ => -1
        };
        if (res == -1) {
            System.Console.WriteLine("В году такой  месяц отсутствует.");
        }
        else {
            System.Console.WriteLine(res);
        }
    }
}
