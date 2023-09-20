﻿using System;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        char c = s[0];
        int res = c switch
        {
            >= '0' and <= '9' => 100,
            >= 'A' and <= 'Z' => 200,
            >= 'a' and <= 'z' => 300,
            _ => 400
        };
        Console.WriteLine(res);
    }
}
