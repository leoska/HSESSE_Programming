using System;
internal class Program
{
    static void Main()
    {
        try
        {
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(a);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Введен неверный тип");
        }
        try
        {
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(b);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Введен неверный тип");
        }
        try
        {
            char c = char.Parse(Console.ReadLine());
            Console.WriteLine(c);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Введен неверный тип");
        }
    }
}
