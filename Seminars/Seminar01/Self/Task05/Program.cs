// Your code here!
using System;

class Program{
    static void Main(){
        Console.Write("Напряжение:");
        var voltageU = float.Parse(Console.ReadLine());
        Console.Write("Сопротивление:");
        var resistanceR = float.Parse(Console.ReadLine());

        var amperageI =  voltageU / resistanceR;
        var electricPowerP = voltageU * voltageU / resistanceR;

        Console.WriteLine($"Сила тока: {amperageI, 6:f2}");
        Console.WriteLine($"Потребляемая мощность электрической цепи: {electricPowerP, 6:f2}");
    }
}
