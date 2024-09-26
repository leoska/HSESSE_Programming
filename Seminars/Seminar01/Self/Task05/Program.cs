// Скорик Егор 239-2
class Program
{

    static void Main(string[] args)
    {
        Console.Write("Введите значение напряжения U: ");
        double.TryParse(Console.ReadLine().Replace('.', ','), out double u);
        Console.WriteLine();

        Console.Write("Введите значение сопротивления R: ");
        double.TryParse(Console.ReadLine().Replace('.', ','), out double r);
        Console.WriteLine();

        if (r != 0)
        {
            Console.WriteLine($"Сила тока I = {u / r}");
            Console.WriteLine($"Потребляемая мощность электрической цепи P = {u * u / r}");
        }
        else
        {
            Console.WriteLine("Сопротивление не должно быть равно 0");
        }
            

    }
}