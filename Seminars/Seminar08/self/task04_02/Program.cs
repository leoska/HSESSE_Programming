namespace task04_02
{
    internal class Program
    {
        public static void InvertDigits(ref int k)
        {
            int n1 = 0;
            int a;
            bool f = true;
            string s = k.ToString();
            int le = s.Length;
            int q = le - 1;
            while (k != 0)
            {
                a = k % 10;
                n1 = n1 + (int)(Math.Pow(10, q)) * a;
                q -= 1;
                k = k / 10;
            }
            k = n1;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter K");
                int k = int.Parse(Console.ReadLine());
                InvertDigits(ref k);
                Console.WriteLine($"Result - {k}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Введены некорректные данные");
            }
        }
    }
}