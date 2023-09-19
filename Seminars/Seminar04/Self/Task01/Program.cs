namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            switch (a)
            {
                case >= '\u0030' and <= '\u0039':
                    Console.WriteLine("a:" + a + " F(a) = 100"); break;
                case >= '\u0041' and <= '\u005A':
                    Console.WriteLine("a:" + a + " F(a) = 200"); break;
                case >= '\u0061' and <= '\u007A':
                    Console.WriteLine("a:" + a + " F(a) = 300"); break;
                default:
                    Console.WriteLine("a:" + a + " F(a) = 400"); break;

            }
        }
    }
}