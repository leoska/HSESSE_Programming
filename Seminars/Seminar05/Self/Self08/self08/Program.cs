namespace self08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int.TryParse(Console.ReadLine(), out int number);
            Console.WriteLine();

            Console.Write("Введите k: ");
            int.TryParse(Console.ReadLine(), out int k);
            Console.WriteLine();

            if (k > number.ToString().Length)
            {
                Console.WriteLine("ошибка: k > количество разрядов числа");
                return;
            }

            string str = "";

            for (int i = 0; i < k; i++)
            {
                str += number.ToString()[i];
            }

            int newNum = int.Parse(str);

            Console.WriteLine(newNum);
        }
    }
}