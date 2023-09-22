namespace Task03;
class Program
{
    static void Main()
    {
        int operationNumber = Convert.ToInt32(Console.ReadLine());
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());

        string operation = "="; // Присваиваем значение, с помощью которого в последствии
        // проверим корректность введенного номера операции.
        double result = 0; // Рандомное значение, чтобы могли запустить программу.

        switch (operationNumber)
        {
            case 1: result = a + b; operation = "+"; break;
            case 2: result = a - b; operation = "-"; break;
            case 3: result = a * b; operation = "*"; break;
            case 4: result = Math.Round(a / b, 3); operation = "/"; break;
            default: break;
        }

        if (operation == "=")
        {
            Console.WriteLine("Operation number is incorrect.");
        }
        else
        {
            if (b < 0)
            {
                Console.WriteLine($"{a} {operation} ({b}) = {result}");
            }
            else
            {
                Console.WriteLine($"{a} {operation} {b} = {result}");
            }
        }
    }
}