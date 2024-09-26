// Your code here!
using System;

class Program {
    static void Main() {
        Console.Write("Введите фамилию: ");
        string surname=Console.ReadLine();
        Console.Write("Введите имя: ");
        string name=Console.ReadLine();
        Console.Write("Введите отчество: ");
        string fathername=Console.ReadLine();
        Console.WriteLine("Ваши фамилия, имя и отчество:");
        Console.Write(surname+" " + name+ " " +fathername);


    }
}
