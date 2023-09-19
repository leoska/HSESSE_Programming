using System.Text;

namespace Prak3
{
    internal class Program
    {
        static void Main()
        {
            // Считывание чисел A и B, введеных пользователем в консоль
            int operationCode = 0;
            
            do
            {
                Console.Write("Введите код операции (1 - 4): ");
            } while (!int.TryParse(Console.ReadLine(), out operationCode));
            
            double A = 0;

            do
            {
                Console.Write("Введите A: ");
            } while (!double.TryParse(Console.ReadLine(), out A));

            double B = 0;

            do
            {
                Console.Write("Введите B (B != 0): ");
            } while (!double.TryParse(Console.ReadLine(), out B) || B == 0);

            // Вывод результата выполненных операций в консоль
            switch (operationCode) {
                case 1: Console.WriteLine($"{A} + {B} = {A + B}"); break;
                case 2: Console.WriteLine($"{A} - {B} = {A - B}"); break;
                case 3: Console.WriteLine($"{A} * {B} = {A * B}"); break;
                case 4: Console.WriteLine($"{A} / {B} = {A / B}"); break;
                default: Console.WriteLine("Данные не корректны!"); break;
            }
        }
    }
}