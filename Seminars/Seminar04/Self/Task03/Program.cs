using System.Xml;

class Program
{
    static void Main()
    {
        Console.Write("Введите код операции: ");
        if (!int.TryParse(Console.ReadLine(), out int code) || code < 1 || code > 4) {
            Console.WriteLine("Данные некорректны.");
            return;
        }
        Console.Write("Введите A: ");
        if (!double.TryParse(Console.ReadLine(), out double a)) {
            Console.WriteLine("Данные некорректны.");
            return;
        }
        Console.Write("Введите B: ");
        if (!double.TryParse(Console.ReadLine(), out double b) || b==0) {
            Console.WriteLine("Данные некорректны.");
            return;
        }
        // присваиваем значение пременной, чтобы избежать ошибки в 31 строке
        double output=0;
        switch (code)
        {
            case 1: output = a+b; break;
            case 2: output = a-b; break;
            case 3: output = a*b; break;
            case 4: output = a/b; break;
        }
        Console.WriteLine(output);
    }
}