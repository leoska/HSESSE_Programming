namespace task04_04
{
    internal class Program
    {
        static void TimeToHMS(int T, out int H, out int  M, out int S)
        {
            H = T / 3600;
            T = T % 3600;
            M = T / 60;
            T = T % 60;
            S = T;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите кол-во секунд");
                int T = int.Parse(Console.ReadLine());
                if (T < 0)
                {
                    Console.WriteLine("Введены некорретные данные");
                }
                else
                {
                    TimeToHMS(T, out int H, out int M, out int S);
                    Console.WriteLine($"В введенном значении {H} часов, {M} минут и {S} секунд");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Введены некорретные данные");
            }
        }
    }
}