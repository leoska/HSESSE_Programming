using System;

class Program{
    static void Main(){
        Console.WriteLine("Введите код операции: ");
        double o = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите А: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите B: ");
        double b = double.Parse(Console.ReadLine()); 

        if(b==0){
            Console.WriteLine("B не может быть равен 0");
            return;
        }

        switch (o)
        {
            case 1:
                Console.WriteLine($"{a} + {b} = {a+b}");
                break;

            case 2:
                Console.WriteLine($"{a} - {b} = {a-b}");
                break;
            
            case 3:
                Console.WriteLine($"{a} * {b} = {a*b}");
                break;

            case 4:
                Console.WriteLine($"{a} / {b} = {a/b}");
                break;

            default:
                Console.WriteLine("Нету такой операции");
                break;

        }        
    }
}
