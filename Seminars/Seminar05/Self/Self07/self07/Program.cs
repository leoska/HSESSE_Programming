namespace self07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            if (!int.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine("ошибка");
                return;
            }
            Console.WriteLine();

            string str = "";

            for (int i = 10; num != 0 ; num /= i)
            {
                str += (num % i).ToString();
            }
            int newNum = int.Parse(str);
            Console.WriteLine(newNum);
        }
    }
}