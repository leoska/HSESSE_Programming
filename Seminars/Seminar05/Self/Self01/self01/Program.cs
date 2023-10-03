namespace self01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 50; i++)
            {
                if (i == 20)
                {
                    continue;
                }
                else
                {
                    string msg = i % 2 == 0 && i % 3 == 0 ? "Число делится на 2 и 3: " : "Число не соответсвует условию: ";
                    Console.WriteLine(msg + i);
                }
            }
            Console.ReadLine();
        }
    }
}